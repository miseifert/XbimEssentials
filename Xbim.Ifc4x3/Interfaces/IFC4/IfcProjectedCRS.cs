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
namespace Xbim.Ifc4x3.RepresentationResource
{
	public partial class @IfcProjectedCRS : IIfcProjectedCRS
	{

		[CrossSchemaAttribute(typeof(IIfcProjectedCRS), 5)]
		Ifc4.MeasureResource.IfcIdentifier? IIfcProjectedCRS.MapProjection 
		{ 
			get
			{
				if (!MapProjection.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(MapProjection.Value);
			} 
			set
			{
				MapProjection = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 new MeasureResource.IfcIdentifier?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcProjectedCRS), 6)]
		Ifc4.MeasureResource.IfcIdentifier? IIfcProjectedCRS.MapZone 
		{ 
			get
			{
				if (!MapZone.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(MapZone.Value);
			} 
			set
			{
				MapZone = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 new MeasureResource.IfcIdentifier?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcProjectedCRS), 7)]
		IIfcNamedUnit IIfcProjectedCRS.MapUnit 
		{ 
			get
			{
				return MapUnit;
			} 
			set
			{
				MapUnit = value as MeasureResource.IfcNamedUnit;
				
			}
		}
	//## Custom code
	//##
	}
}