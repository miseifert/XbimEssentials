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
namespace Xbim.Ifc4x3.StructuralLoadResource
{
	public partial class @IfcSlippageConnectionCondition : IIfcSlippageConnectionCondition
	{

		[CrossSchemaAttribute(typeof(IIfcSlippageConnectionCondition), 2)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcSlippageConnectionCondition.SlippageX 
		{ 
			get
			{
				if (!SlippageX.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(SlippageX.Value);
			} 
			set
			{
				SlippageX = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSlippageConnectionCondition), 3)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcSlippageConnectionCondition.SlippageY 
		{ 
			get
			{
				if (!SlippageY.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(SlippageY.Value);
			} 
			set
			{
				SlippageY = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSlippageConnectionCondition), 4)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcSlippageConnectionCondition.SlippageZ 
		{ 
			get
			{
				if (!SlippageZ.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(SlippageZ.Value);
			} 
			set
			{
				SlippageZ = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}