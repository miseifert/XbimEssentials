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
namespace Xbim.Ifc4x3.QuantityResource
{
	public partial class @IfcQuantityArea : IIfcQuantityArea
	{

		[CrossSchemaAttribute(typeof(IIfcQuantityArea), 4)]
		Ifc4.MeasureResource.IfcAreaMeasure IIfcQuantityArea.AreaValue 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcAreaMeasure(AreaValue);
			} 
			set
			{
				AreaValue = new MeasureResource.IfcAreaMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcQuantityArea), 5)]
		Ifc4.MeasureResource.IfcLabel? IIfcQuantityArea.Formula 
		{ 
			get
			{
				if (!Formula.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Formula.Value);
			} 
			set
			{
				Formula = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}