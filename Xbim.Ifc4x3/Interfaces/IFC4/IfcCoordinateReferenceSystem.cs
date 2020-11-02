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
namespace Xbim.Ifc4x3.RepresentationResource
{
	public partial class @IfcCoordinateReferenceSystem : IIfcCoordinateReferenceSystem
	{

		[CrossSchemaAttribute(typeof(IIfcCoordinateReferenceSystem), 1)]
		Ifc4.MeasureResource.IfcLabel IIfcCoordinateReferenceSystem.Name 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Name);
			} 
			set
			{
				Name = new MeasureResource.IfcLabel(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCoordinateReferenceSystem), 2)]
		Ifc4.MeasureResource.IfcText? IIfcCoordinateReferenceSystem.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCoordinateReferenceSystem), 3)]
		Ifc4.MeasureResource.IfcIdentifier? IIfcCoordinateReferenceSystem.GeodeticDatum 
		{ 
			get
			{
				if (!GeodeticDatum.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(GeodeticDatum.Value);
			} 
			set
			{
				GeodeticDatum = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 new MeasureResource.IfcIdentifier?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCoordinateReferenceSystem), 4)]
		Ifc4.MeasureResource.IfcIdentifier? IIfcCoordinateReferenceSystem.VerticalDatum 
		{ 
			get
			{
				if (!VerticalDatum.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(VerticalDatum.Value);
			} 
			set
			{
				VerticalDatum = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 new MeasureResource.IfcIdentifier?() ;
				
			}
		}
		IEnumerable<IIfcCoordinateOperation> IIfcCoordinateReferenceSystem.HasCoordinateOperation 
		{ 
			get
			{
				return Model.Instances.Where<IIfcCoordinateOperation>(e => (e.SourceCRS as IfcCoordinateReferenceSystem) == this, "SourceCRS", this);
			} 
		}
	//## Custom code
	//##
	}
}