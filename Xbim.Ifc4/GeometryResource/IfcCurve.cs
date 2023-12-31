// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricModelResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurve : IIfcGeometricRepresentationItem, IfcGeometricSetSelect
	{
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcCurve", 68)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcCurve : IfcGeometricRepresentationItem, IIfcCurve, IEquatable<@IfcCurve>
	{
		#region IIfcCurve explicit implementation
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurve(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}



		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
				if (this as IfcLine != null)
			        return (this as IfcLine).Pnt.Dim;
				if (this as IfcConic != null)
			        return (this as IfcConic).Position.Dim;
				if (this as IfcPolyline != null)
			        return (this as IfcPolyline).Points[1].Dim;
				if (this as IfcTrimmedCurve != null)
			        return (this as IfcTrimmedCurve).BasisCurve.Dim;
				if (this is IfcCompositeCurve composive && composive.Segments.Count > 0)
			        return composive.Segments.Count == 1 ? composive.Segments[0].Dim : composive.Segments[1].Dim;
				if (this is IfcBSplineCurve bSplitted && bSplitted.ControlPointsList.Count > 0)
			        return bSplitted.ControlPointsList.Count == 1 ? bSplitted.ControlPointsList[0].Dim : bSplitted.ControlPointsList[1].Dim;
			    if (this is IfcOffsetCurve2D)
			        return 2;
                if (this is IfcOffsetCurve3D)
			        return 3;
				if (this is IfcPcurve)
			        return 3;
				if (this is IfcIndexedPolyCurve pc)
					return pc.Points.Dim;
				return new IfcDimensionCount(0);
			    //##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurve other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}