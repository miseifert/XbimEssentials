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
namespace Xbim.Ifc4x3.GeometricModelResource
{
	public partial class @IfcRevolvedAreaSolid : IIfcRevolvedAreaSolid
	{

		[CrossSchemaAttribute(typeof(IIfcRevolvedAreaSolid), 3)]
		IIfcAxis1Placement IIfcRevolvedAreaSolid.Axis 
		{ 
			get
			{
				return Axis;
			} 
			set
			{
				Axis = value as GeometryResource.IfcAxis1Placement;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRevolvedAreaSolid), 4)]
		Ifc4.MeasureResource.IfcPlaneAngleMeasure IIfcRevolvedAreaSolid.Angle 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPlaneAngleMeasure(Angle);
			} 
			set
			{
				Angle = new MeasureResource.IfcPlaneAngleMeasure(value);
				
			}
		}
		Common.Geometry.XbimLine IIfcRevolvedAreaSolid.AxisLine 
		{
			get 
			{
				return AxisLine;
			}
		}

	//## Custom code
	//##
	}
}