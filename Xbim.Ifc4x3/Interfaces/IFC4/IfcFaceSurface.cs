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
namespace Xbim.Ifc4x3.TopologyResource
{
	public partial class @IfcFaceSurface : IIfcFaceSurface
	{

		[CrossSchemaAttribute(typeof(IIfcFaceSurface), 2)]
		IIfcSurface IIfcFaceSurface.FaceSurface 
		{ 
			get
			{
				return FaceSurface;
			} 
			set
			{
				FaceSurface = value as GeometryResource.IfcSurface;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcFaceSurface), 3)]
		Ifc4.MeasureResource.IfcBoolean IIfcFaceSurface.SameSense 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcBoolean(SameSense);
			} 
			set
			{
				SameSense = new MeasureResource.IfcBoolean(value);
				
			}
		}
	//## Custom code
	//##
	}
}