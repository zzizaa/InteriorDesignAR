#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodExecutionContextInfo g_methodExecutionContextInfos[1] = { { 0, 0, 0 } };
#else
static const Il2CppMethodExecutionContextInfo g_methodExecutionContextInfos[1] = { { 0, 0, 0 } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const char* g_methodExecutionContextInfoStrings[1] = { NULL };
#else
static const char* g_methodExecutionContextInfoStrings[1] = { NULL };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodExecutionContextInfoIndex g_methodExecutionContextInfoIndexes[20] = 
{
	{ 0, 0 } /* 0x06000001 System.Void UnityEngine.AI.NavMeshPath::.ctor() */,
	{ 0, 0 } /* 0x06000002 System.Void UnityEngine.AI.NavMeshPath::Finalize() */,
	{ 0, 0 } /* 0x06000003 System.IntPtr UnityEngine.AI.NavMeshPath::InitializeNavMeshPath() */,
	{ 0, 0 } /* 0x06000004 System.Void UnityEngine.AI.NavMeshPath::DestroyNavMeshPath(System.IntPtr) */,
	{ 0, 0 } /* 0x06000005 System.Void UnityEngine.AI.NavMeshPath::ClearCornersInternal() */,
	{ 0, 0 } /* 0x06000006 System.Void UnityEngine.AI.NavMeshPath::ClearCorners() */,
	{ 0, 0 } /* 0x06000007 UnityEngine.AI.NavMeshPathStatus UnityEngine.AI.NavMeshPath::get_status() */,
	{ 0, 0 } /* 0x06000008 UnityEngine.Vector3 UnityEngine.AI.NavMeshHit::get_position() */,
	{ 0, 0 } /* 0x06000009 System.Single UnityEngine.AI.NavMeshHit::get_distance() */,
	{ 0, 0 } /* 0x0600000A System.Void UnityEngine.AI.NavMesh::Internal_CallOnNavMeshPreUpdate() */,
	{ 0, 0 } /* 0x0600000B System.Boolean UnityEngine.AI.NavMesh::Raycast(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.AI.NavMeshHit&,System.Int32) */,
	{ 0, 0 } /* 0x0600000C System.Boolean UnityEngine.AI.NavMesh::CalculatePath(UnityEngine.Vector3,UnityEngine.Vector3,System.Int32,UnityEngine.AI.NavMeshPath) */,
	{ 0, 0 } /* 0x0600000D System.Boolean UnityEngine.AI.NavMesh::CalculatePathInternal(UnityEngine.Vector3,UnityEngine.Vector3,System.Int32,UnityEngine.AI.NavMeshPath) */,
	{ 0, 0 } /* 0x0600000E System.Boolean UnityEngine.AI.NavMesh::SamplePosition(UnityEngine.Vector3,UnityEngine.AI.NavMeshHit&,System.Single,System.Int32) */,
	{ 0, 0 } /* 0x0600000F System.Int32 UnityEngine.AI.NavMesh::GetAreaFromName(System.String) */,
	{ 0, 0 } /* 0x06000010 System.Boolean UnityEngine.AI.NavMesh::Raycast_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Int32) */,
	{ 0, 0 } /* 0x06000011 System.Boolean UnityEngine.AI.NavMesh::CalculatePathInternal_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,System.Int32,UnityEngine.AI.NavMeshPath) */,
	{ 0, 0 } /* 0x06000012 System.Boolean UnityEngine.AI.NavMesh::SamplePosition_Injected(UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Single,System.Int32) */,
	{ 0, 0 } /* 0x06000013 System.Void UnityEngine.AI.NavMesh/OnNavMeshPreUpdate::.ctor(System.Object,System.IntPtr) */,
	{ 0, 0 } /* 0x06000014 System.Void UnityEngine.AI.NavMesh/OnNavMeshPreUpdate::Invoke() */,
};
#else
static const Il2CppMethodExecutionContextInfoIndex g_methodExecutionContextInfoIndexes[1] = { { 0, 0} };
#endif
#if IL2CPP_MONO_DEBUGGER
IL2CPP_EXTERN_C Il2CppSequencePoint g_sequencePointsUnityEngine_AIModule[];
Il2CppSequencePoint g_sequencePointsUnityEngine_AIModule[51] = 
{
	{ 47967, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 0 } /* seqPointIndex: 0 */,
	{ 47967, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 1 } /* seqPointIndex: 1 */,
	{ 47967, 1, 27, 27, 9, 29, 0, kSequencePointKind_Normal, 0, 2 } /* seqPointIndex: 2 */,
	{ 47967, 1, 27, 27, 9, 29, 1, kSequencePointKind_StepOut, 0, 3 } /* seqPointIndex: 3 */,
	{ 47967, 1, 28, 28, 9, 10, 7, kSequencePointKind_Normal, 0, 4 } /* seqPointIndex: 4 */,
	{ 47967, 1, 29, 29, 13, 45, 8, kSequencePointKind_Normal, 0, 5 } /* seqPointIndex: 5 */,
	{ 47967, 1, 29, 29, 13, 45, 9, kSequencePointKind_StepOut, 0, 6 } /* seqPointIndex: 6 */,
	{ 47967, 1, 30, 30, 9, 10, 19, kSequencePointKind_Normal, 0, 7 } /* seqPointIndex: 7 */,
	{ 47968, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 8 } /* seqPointIndex: 8 */,
	{ 47968, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 9 } /* seqPointIndex: 9 */,
	{ 47968, 1, 33, 33, 9, 10, 0, kSequencePointKind_Normal, 0, 10 } /* seqPointIndex: 10 */,
	{ 47968, 1, 33, 33, 9, 10, 1, kSequencePointKind_Normal, 0, 11 } /* seqPointIndex: 11 */,
	{ 47968, 1, 34, 34, 13, 39, 2, kSequencePointKind_Normal, 0, 12 } /* seqPointIndex: 12 */,
	{ 47968, 1, 34, 34, 13, 39, 8, kSequencePointKind_StepOut, 0, 13 } /* seqPointIndex: 13 */,
	{ 47968, 1, 35, 35, 13, 33, 14, kSequencePointKind_Normal, 0, 14 } /* seqPointIndex: 14 */,
	{ 47968, 1, 36, 36, 9, 10, 27, kSequencePointKind_Normal, 0, 15 } /* seqPointIndex: 15 */,
	{ 47968, 1, 36, 36, 9, 10, 28, kSequencePointKind_StepOut, 0, 16 } /* seqPointIndex: 16 */,
	{ 47968, 1, 36, 36, 9, 10, 35, kSequencePointKind_Normal, 0, 17 } /* seqPointIndex: 17 */,
	{ 47972, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 18 } /* seqPointIndex: 18 */,
	{ 47972, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 19 } /* seqPointIndex: 19 */,
	{ 47972, 1, 55, 55, 9, 10, 0, kSequencePointKind_Normal, 0, 20 } /* seqPointIndex: 20 */,
	{ 47972, 1, 56, 56, 13, 36, 1, kSequencePointKind_Normal, 0, 21 } /* seqPointIndex: 21 */,
	{ 47972, 1, 56, 56, 13, 36, 2, kSequencePointKind_StepOut, 0, 22 } /* seqPointIndex: 22 */,
	{ 47972, 1, 57, 57, 13, 30, 8, kSequencePointKind_Normal, 0, 23 } /* seqPointIndex: 23 */,
	{ 47972, 1, 58, 58, 9, 10, 15, kSequencePointKind_Normal, 0, 24 } /* seqPointIndex: 24 */,
	{ 47974, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 25 } /* seqPointIndex: 25 */,
	{ 47974, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 26 } /* seqPointIndex: 26 */,
	{ 47974, 2, 20, 20, 39, 40, 0, kSequencePointKind_Normal, 0, 27 } /* seqPointIndex: 27 */,
	{ 47974, 2, 20, 20, 41, 59, 1, kSequencePointKind_Normal, 0, 28 } /* seqPointIndex: 28 */,
	{ 47974, 2, 20, 20, 60, 61, 10, kSequencePointKind_Normal, 0, 29 } /* seqPointIndex: 29 */,
	{ 47975, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 30 } /* seqPointIndex: 30 */,
	{ 47975, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 31 } /* seqPointIndex: 31 */,
	{ 47975, 2, 26, 26, 37, 38, 0, kSequencePointKind_Normal, 0, 32 } /* seqPointIndex: 32 */,
	{ 47975, 2, 26, 26, 39, 57, 1, kSequencePointKind_Normal, 0, 33 } /* seqPointIndex: 33 */,
	{ 47975, 2, 26, 26, 58, 59, 10, kSequencePointKind_Normal, 0, 34 } /* seqPointIndex: 34 */,
	{ 47976, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 35 } /* seqPointIndex: 35 */,
	{ 47976, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 36 } /* seqPointIndex: 36 */,
	{ 47976, 2, 191, 191, 9, 10, 0, kSequencePointKind_Normal, 0, 37 } /* seqPointIndex: 37 */,
	{ 47976, 2, 192, 192, 13, 37, 1, kSequencePointKind_Normal, 0, 38 } /* seqPointIndex: 38 */,
	{ 47976, 2, 192, 192, 0, 0, 10, kSequencePointKind_Normal, 0, 39 } /* seqPointIndex: 39 */,
	{ 47976, 2, 193, 193, 17, 31, 13, kSequencePointKind_Normal, 0, 40 } /* seqPointIndex: 40 */,
	{ 47976, 2, 193, 193, 17, 31, 18, kSequencePointKind_StepOut, 0, 41 } /* seqPointIndex: 41 */,
	{ 47976, 2, 194, 194, 9, 10, 24, kSequencePointKind_Normal, 0, 42 } /* seqPointIndex: 42 */,
	{ 47978, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 43 } /* seqPointIndex: 43 */,
	{ 47978, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 44 } /* seqPointIndex: 44 */,
	{ 47978, 2, 201, 201, 9, 10, 0, kSequencePointKind_Normal, 0, 45 } /* seqPointIndex: 45 */,
	{ 47978, 2, 202, 202, 13, 33, 1, kSequencePointKind_Normal, 0, 46 } /* seqPointIndex: 46 */,
	{ 47978, 2, 202, 202, 13, 33, 2, kSequencePointKind_StepOut, 0, 47 } /* seqPointIndex: 47 */,
	{ 47978, 2, 203, 203, 13, 90, 8, kSequencePointKind_Normal, 0, 48 } /* seqPointIndex: 48 */,
	{ 47978, 2, 203, 203, 13, 90, 12, kSequencePointKind_StepOut, 0, 49 } /* seqPointIndex: 49 */,
	{ 47978, 2, 204, 204, 9, 10, 20, kSequencePointKind_Normal, 0, 50 } /* seqPointIndex: 50 */,
};
#else
extern Il2CppSequencePoint g_sequencePointsUnityEngine_AIModule[];
Il2CppSequencePoint g_sequencePointsUnityEngine_AIModule[1] = { { 0, 0, 0, 0, 0, 0, 0, kSequencePointKind_Normal, 0, 0, } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppCatchPoint g_catchPoints[1] = { { 0, 0, 0, 0, } };
#else
static const Il2CppCatchPoint g_catchPoints[1] = { { 0, 0, 0, 0, } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppSequencePointSourceFile g_sequencePointSourceFiles[] = {
{ "", { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} }, //0 
{ "\\home\\bokken\\build\\output\\unity\\unity\\Modules\\AI\\NavMeshPath.bindings.cs", { 66, 3, 88, 21, 124, 161, 11, 83, 53, 109, 148, 35, 162, 15, 29, 231} }, //1 
{ "\\home\\bokken\\build\\output\\unity\\unity\\Modules\\AI\\NavMesh\\NavMesh.bindings.cs", { 78, 134, 30, 187, 108, 93, 113, 40, 31, 206, 197, 55, 133, 43, 114, 169} }, //2 
};
#else
static const Il2CppSequencePointSourceFile g_sequencePointSourceFiles[1] = { NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppTypeSourceFilePair g_typeSourceFiles[3] = 
{
	{ 7517, 1 },
	{ 7518, 2 },
	{ 7520, 2 },
};
#else
static const Il2CppTypeSourceFilePair g_typeSourceFiles[1] = { { 0, 0 } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodScope g_methodScopes[4] = 
{
	{ 0, 12 },
	{ 0, 12 },
	{ 0, 25 },
	{ 0, 22 },
};
#else
static const Il2CppMethodScope g_methodScopes[1] = { { 0, 0 } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodHeaderInfo g_methodHeaderInfos[20] = 
{
	{ 0, 0, 0 } /* System.Void UnityEngine.AI.NavMeshPath::.ctor() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.AI.NavMeshPath::Finalize() */,
	{ 0, 0, 0 } /* System.IntPtr UnityEngine.AI.NavMeshPath::InitializeNavMeshPath() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.AI.NavMeshPath::DestroyNavMeshPath(System.IntPtr) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.AI.NavMeshPath::ClearCornersInternal() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.AI.NavMeshPath::ClearCorners() */,
	{ 0, 0, 0 } /* UnityEngine.AI.NavMeshPathStatus UnityEngine.AI.NavMeshPath::get_status() */,
	{ 12, 0, 1 } /* UnityEngine.Vector3 UnityEngine.AI.NavMeshHit::get_position() */,
	{ 12, 1, 1 } /* System.Single UnityEngine.AI.NavMeshHit::get_distance() */,
	{ 25, 2, 1 } /* System.Void UnityEngine.AI.NavMesh::Internal_CallOnNavMeshPreUpdate() */,
	{ 0, 0, 0 } /* System.Boolean UnityEngine.AI.NavMesh::Raycast(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.AI.NavMeshHit&,System.Int32) */,
	{ 22, 3, 1 } /* System.Boolean UnityEngine.AI.NavMesh::CalculatePath(UnityEngine.Vector3,UnityEngine.Vector3,System.Int32,UnityEngine.AI.NavMeshPath) */,
	{ 0, 0, 0 } /* System.Boolean UnityEngine.AI.NavMesh::CalculatePathInternal(UnityEngine.Vector3,UnityEngine.Vector3,System.Int32,UnityEngine.AI.NavMeshPath) */,
	{ 0, 0, 0 } /* System.Boolean UnityEngine.AI.NavMesh::SamplePosition(UnityEngine.Vector3,UnityEngine.AI.NavMeshHit&,System.Single,System.Int32) */,
	{ 0, 0, 0 } /* System.Int32 UnityEngine.AI.NavMesh::GetAreaFromName(System.String) */,
	{ 0, 0, 0 } /* System.Boolean UnityEngine.AI.NavMesh::Raycast_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Int32) */,
	{ 0, 0, 0 } /* System.Boolean UnityEngine.AI.NavMesh::CalculatePathInternal_Injected(UnityEngine.Vector3&,UnityEngine.Vector3&,System.Int32,UnityEngine.AI.NavMeshPath) */,
	{ 0, 0, 0 } /* System.Boolean UnityEngine.AI.NavMesh::SamplePosition_Injected(UnityEngine.Vector3&,UnityEngine.AI.NavMeshHit&,System.Single,System.Int32) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.AI.NavMesh/OnNavMeshPreUpdate::.ctor(System.Object,System.IntPtr) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.AI.NavMesh/OnNavMeshPreUpdate::Invoke() */,
};
#else
static const Il2CppMethodHeaderInfo g_methodHeaderInfos[1] = { { 0, 0, 0 } };
#endif
IL2CPP_EXTERN_C const Il2CppDebuggerMetadataRegistration g_DebuggerMetadataRegistrationUnityEngine_AIModule;
const Il2CppDebuggerMetadataRegistration g_DebuggerMetadataRegistrationUnityEngine_AIModule = 
{
	(Il2CppMethodExecutionContextInfo*)g_methodExecutionContextInfos,
	(Il2CppMethodExecutionContextInfoIndex*)g_methodExecutionContextInfoIndexes,
	(Il2CppMethodScope*)g_methodScopes,
	(Il2CppMethodHeaderInfo*)g_methodHeaderInfos,
	(Il2CppSequencePointSourceFile*)g_sequencePointSourceFiles,
	51,
	(Il2CppSequencePoint*)g_sequencePointsUnityEngine_AIModule,
	0,
	(Il2CppCatchPoint*)g_catchPoints,
	3,
	(Il2CppTypeSourceFilePair*)g_typeSourceFiles,
	(const char**)g_methodExecutionContextInfoStrings,
};
