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
namespace Xbim.Ifc4x3.StructuralLoadResource
{
	public partial class @IfcStructuralLoadPlanarForce : IIfcStructuralLoadPlanarForce
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadPlanarForce), 2)]
		Ifc4.MeasureResource.IfcPlanarForceMeasure? IIfcStructuralLoadPlanarForce.PlanarForceX 
		{ 
			get
			{
				if (!PlanarForceX.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPlanarForceMeasure(PlanarForceX.Value);
			} 
			set
			{
				PlanarForceX = value.HasValue ? 
					new MeasureResource.IfcPlanarForceMeasure(value.Value) :  
					 new MeasureResource.IfcPlanarForceMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadPlanarForce), 3)]
		Ifc4.MeasureResource.IfcPlanarForceMeasure? IIfcStructuralLoadPlanarForce.PlanarForceY 
		{ 
			get
			{
				if (!PlanarForceY.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPlanarForceMeasure(PlanarForceY.Value);
			} 
			set
			{
				PlanarForceY = value.HasValue ? 
					new MeasureResource.IfcPlanarForceMeasure(value.Value) :  
					 new MeasureResource.IfcPlanarForceMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadPlanarForce), 4)]
		Ifc4.MeasureResource.IfcPlanarForceMeasure? IIfcStructuralLoadPlanarForce.PlanarForceZ 
		{ 
			get
			{
				if (!PlanarForceZ.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPlanarForceMeasure(PlanarForceZ.Value);
			} 
			set
			{
				PlanarForceZ = value.HasValue ? 
					new MeasureResource.IfcPlanarForceMeasure(value.Value) :  
					 new MeasureResource.IfcPlanarForceMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}