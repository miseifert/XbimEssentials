// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralCurveMember : IIfcStructuralCurveMember
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralCurveMember), 8)]
		Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum IIfcStructuralCurveMember.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcStructuralCurveMemberTypeEnum.CABLE:
						return Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.CABLE;
					case IfcStructuralCurveMemberTypeEnum.COMPRESSION_MEMBER:
						return Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.COMPRESSION_MEMBER;
					case IfcStructuralCurveMemberTypeEnum.PIN_JOINED_MEMBER:
						return Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.PIN_JOINED_MEMBER;
					case IfcStructuralCurveMemberTypeEnum.RIGID_JOINED_MEMBER:
						return Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.RIGID_JOINED_MEMBER;
					case IfcStructuralCurveMemberTypeEnum.TENSION_MEMBER:
						return Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.TENSION_MEMBER;
					case IfcStructuralCurveMemberTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.USERDEFINED;
					case IfcStructuralCurveMemberTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.RIGID_JOINED_MEMBER:
						PredefinedType = IfcStructuralCurveMemberTypeEnum.RIGID_JOINED_MEMBER;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.PIN_JOINED_MEMBER:
						PredefinedType = IfcStructuralCurveMemberTypeEnum.PIN_JOINED_MEMBER;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.CABLE:
						PredefinedType = IfcStructuralCurveMemberTypeEnum.CABLE;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.TENSION_MEMBER:
						PredefinedType = IfcStructuralCurveMemberTypeEnum.TENSION_MEMBER;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.COMPRESSION_MEMBER:
						PredefinedType = IfcStructuralCurveMemberTypeEnum.COMPRESSION_MEMBER;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.USERDEFINED:
						PredefinedType = IfcStructuralCurveMemberTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveMemberTypeEnum.NOTDEFINED:
						PredefinedType = IfcStructuralCurveMemberTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralCurveMember), 9)]
		IIfcDirection IIfcStructuralCurveMember.Axis 
		{ 
			get
			{
				return Axis;
			} 
			set
			{
				Axis = value as GeometryResource.IfcDirection;
				
			}
		}
	//## Custom code
	//##
	}
}