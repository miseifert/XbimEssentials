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
namespace Xbim.Ifc4x3.SharedMgmtElements
{
	public partial class @IfcPermit : IIfcPermit
	{

		[CrossSchemaAttribute(typeof(IIfcPermit), 7)]
		Ifc4.Interfaces.IfcPermitTypeEnum? IIfcPermit.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcPermitTypeEnum.ACCESS:
						return Ifc4.Interfaces.IfcPermitTypeEnum.ACCESS;
					case IfcPermitTypeEnum.BUILDING:
						return Ifc4.Interfaces.IfcPermitTypeEnum.BUILDING;
					case IfcPermitTypeEnum.WORK:
						return Ifc4.Interfaces.IfcPermitTypeEnum.WORK;
					case IfcPermitTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcPermitTypeEnum.USERDEFINED;
					case IfcPermitTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcPermitTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
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
					case Ifc4.Interfaces.IfcPermitTypeEnum.ACCESS:
						PredefinedType = IfcPermitTypeEnum.ACCESS;
						return;
					case Ifc4.Interfaces.IfcPermitTypeEnum.BUILDING:
						PredefinedType = IfcPermitTypeEnum.BUILDING;
						return;
					case Ifc4.Interfaces.IfcPermitTypeEnum.WORK:
						PredefinedType = IfcPermitTypeEnum.WORK;
						return;
					case Ifc4.Interfaces.IfcPermitTypeEnum.USERDEFINED:
						PredefinedType = IfcPermitTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcPermitTypeEnum.NOTDEFINED:
						PredefinedType = IfcPermitTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPermit), 8)]
		Ifc4.MeasureResource.IfcLabel? IIfcPermit.Status 
		{ 
			get
			{
				if (!Status.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Status.Value);
			} 
			set
			{
				Status = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPermit), 9)]
		Ifc4.MeasureResource.IfcText? IIfcPermit.LongDescription 
		{ 
			get
			{
				if (!LongDescription.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(LongDescription.Value);
			} 
			set
			{
				LongDescription = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}
	//## Custom code
	//##
	}
}