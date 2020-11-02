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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ProcessExtension
{
	public partial class @IfcWorkPlan : IIfcWorkPlan
	{

		[CrossSchemaAttribute(typeof(IIfcWorkPlan), 14)]
		Ifc4.Interfaces.IfcWorkPlanTypeEnum? IIfcWorkPlan.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcWorkPlanTypeEnum.ACTUAL:
						return Ifc4.Interfaces.IfcWorkPlanTypeEnum.ACTUAL;
					case IfcWorkPlanTypeEnum.BASELINE:
						return Ifc4.Interfaces.IfcWorkPlanTypeEnum.BASELINE;
					case IfcWorkPlanTypeEnum.PLANNED:
						return Ifc4.Interfaces.IfcWorkPlanTypeEnum.PLANNED;
					case IfcWorkPlanTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcWorkPlanTypeEnum.USERDEFINED;
					case IfcWorkPlanTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcWorkPlanTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcWorkPlanTypeEnum.ACTUAL:
						PredefinedType = IfcWorkPlanTypeEnum.ACTUAL;
						return;
					case Ifc4.Interfaces.IfcWorkPlanTypeEnum.BASELINE:
						PredefinedType = IfcWorkPlanTypeEnum.BASELINE;
						return;
					case Ifc4.Interfaces.IfcWorkPlanTypeEnum.PLANNED:
						PredefinedType = IfcWorkPlanTypeEnum.PLANNED;
						return;
					case Ifc4.Interfaces.IfcWorkPlanTypeEnum.USERDEFINED:
						PredefinedType = IfcWorkPlanTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcWorkPlanTypeEnum.NOTDEFINED:
						PredefinedType = IfcWorkPlanTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}