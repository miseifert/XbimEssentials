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
	public partial class @IfcStructuralLoadLinearForce : IIfcStructuralLoadLinearForce
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadLinearForce), 2)]
		Ifc4.MeasureResource.IfcLinearForceMeasure? IIfcStructuralLoadLinearForce.LinearForceX 
		{ 
			get
			{
				if (!LinearForceX.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLinearForceMeasure(LinearForceX.Value);
			} 
			set
			{
				LinearForceX = value.HasValue ? 
					new MeasureResource.IfcLinearForceMeasure(value.Value) :  
					 new MeasureResource.IfcLinearForceMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadLinearForce), 3)]
		Ifc4.MeasureResource.IfcLinearForceMeasure? IIfcStructuralLoadLinearForce.LinearForceY 
		{ 
			get
			{
				if (!LinearForceY.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLinearForceMeasure(LinearForceY.Value);
			} 
			set
			{
				LinearForceY = value.HasValue ? 
					new MeasureResource.IfcLinearForceMeasure(value.Value) :  
					 new MeasureResource.IfcLinearForceMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadLinearForce), 4)]
		Ifc4.MeasureResource.IfcLinearForceMeasure? IIfcStructuralLoadLinearForce.LinearForceZ 
		{ 
			get
			{
				if (!LinearForceZ.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLinearForceMeasure(LinearForceZ.Value);
			} 
			set
			{
				LinearForceZ = value.HasValue ? 
					new MeasureResource.IfcLinearForceMeasure(value.Value) :  
					 new MeasureResource.IfcLinearForceMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadLinearForce), 5)]
		Ifc4.MeasureResource.IfcLinearMomentMeasure? IIfcStructuralLoadLinearForce.LinearMomentX 
		{ 
			get
			{
				if (!LinearMomentX.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLinearMomentMeasure(LinearMomentX.Value);
			} 
			set
			{
				LinearMomentX = value.HasValue ? 
					new MeasureResource.IfcLinearMomentMeasure(value.Value) :  
					 new MeasureResource.IfcLinearMomentMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadLinearForce), 6)]
		Ifc4.MeasureResource.IfcLinearMomentMeasure? IIfcStructuralLoadLinearForce.LinearMomentY 
		{ 
			get
			{
				if (!LinearMomentY.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLinearMomentMeasure(LinearMomentY.Value);
			} 
			set
			{
				LinearMomentY = value.HasValue ? 
					new MeasureResource.IfcLinearMomentMeasure(value.Value) :  
					 new MeasureResource.IfcLinearMomentMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadLinearForce), 7)]
		Ifc4.MeasureResource.IfcLinearMomentMeasure? IIfcStructuralLoadLinearForce.LinearMomentZ 
		{ 
			get
			{
				if (!LinearMomentZ.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLinearMomentMeasure(LinearMomentZ.Value);
			} 
			set
			{
				LinearMomentZ = value.HasValue ? 
					new MeasureResource.IfcLinearMomentMeasure(value.Value) :  
					 new MeasureResource.IfcLinearMomentMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}