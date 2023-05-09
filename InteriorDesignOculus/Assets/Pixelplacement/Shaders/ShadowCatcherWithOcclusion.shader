Shader "Pixelplacement/ShadowCatcherWithOcclusion"
{
    SubShader
    {
        Tags {"Queue"="Geometry" }
 
        Pass
        {
            Tags {"LightMode" = "ForwardBase" }
            Cull Back
            Blend SrcAlpha OneMinusSrcAlpha
            
            Stencil
            {
			    Ref 1
			    Comp always
			    Pass replace
		    }
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_fwdbase
 
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"


            struct appdata
            {
                UNITY_VERTEX_INPUT_INSTANCE_ID    
            };
            
            struct v2f
            {
                float4 pos : SV_POSITION;
                LIGHTING_COORDS(0,1)
                UNITY_VERTEX_OUTPUT_STEREO
            };
            v2f vert(appdata_base v)
            {
                v2f o;
                UNITY_SETUP_INSTANCE_ID(v)
                UNITY_INITIALIZE_OUTPUT(v2f, o)
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o)
                o.pos = UnityObjectToClipPos (v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o);
             
                return o;
            }
            fixed4 frag(v2f i) : COLOR
            {
                UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(i)
                float attenuation = LIGHT_ATTENUATION(i);
                return fixed4(0,0,0,1-attenuation);
            }
            ENDCG
        }
 
    }
    Fallback "VertexLit"
}