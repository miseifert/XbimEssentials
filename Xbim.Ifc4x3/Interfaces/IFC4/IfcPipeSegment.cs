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
namespace Xbim.Ifc4x3.HvacDomain
{
	public partial class @IfcPipeSegment : IIfcPipeSegment
	{

		[CrossSchemaAttribute(typeof(IIfcPipeSegment), 9)]
		Ifc4.Interfaces.IfcPipeSegmentTypeEnum? IIfcPipeSegment.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcPipeSegmentTypeEnum.CULVERT:
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.CULVERT;
					case IfcPipeSegmentTypeEnum.FLEXIBLESEGMENT:
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.FLEXIBLESEGMENT;
					case IfcPipeSegmentTypeEnum.RIGIDSEGMENT:
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.RIGIDSEGMENT;
					case IfcPipeSegmentTypeEnum.GUTTER:
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.GUTTER;
					case IfcPipeSegmentTypeEnum.SPOOL:
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.SPOOL;
					case IfcPipeSegmentTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.USERDEFINED;
					case IfcPipeSegmentTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcPipeSegmentTypeEnum.CULVERT:
						PredefinedType = IfcPipeSegmentTypeEnum.CULVERT;
						return;
					case Ifc4.Interfaces.IfcPipeSegmentTypeEnum.FLEXIBLESEGMENT:
						PredefinedType = IfcPipeSegmentTypeEnum.FLEXIBLESEGMENT;
						return;
					case Ifc4.Interfaces.IfcPipeSegmentTypeEnum.RIGIDSEGMENT:
						PredefinedType = IfcPipeSegmentTypeEnum.RIGIDSEGMENT;
						return;
					case Ifc4.Interfaces.IfcPipeSegmentTypeEnum.GUTTER:
						PredefinedType = IfcPipeSegmentTypeEnum.GUTTER;
						return;
					case Ifc4.Interfaces.IfcPipeSegmentTypeEnum.SPOOL:
						PredefinedType = IfcPipeSegmentTypeEnum.SPOOL;
						return;
					case Ifc4.Interfaces.IfcPipeSegmentTypeEnum.USERDEFINED:
						PredefinedType = IfcPipeSegmentTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcPipeSegmentTypeEnum.NOTDEFINED:
						PredefinedType = IfcPipeSegmentTypeEnum.NOTDEFINED;
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