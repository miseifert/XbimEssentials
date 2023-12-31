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
	public partial class @IfcPhysicalQuantity : IIfcPhysicalQuantity
	{

		[CrossSchemaAttribute(typeof(IIfcPhysicalQuantity), 1)]
		Ifc4.MeasureResource.IfcLabel IIfcPhysicalQuantity.Name 
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

		[CrossSchemaAttribute(typeof(IIfcPhysicalQuantity), 2)]
		Ifc4.MeasureResource.IfcText? IIfcPhysicalQuantity.Description 
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
		IEnumerable<IIfcExternalReferenceRelationship> IIfcPhysicalQuantity.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
		IEnumerable<IIfcPhysicalComplexQuantity> IIfcPhysicalQuantity.PartOfComplex 
		{ 
			get
			{
				return Model.Instances.Where<IIfcPhysicalComplexQuantity>(e => e.HasQuantities != null &&  e.HasQuantities.Contains(this), "HasQuantities", this);
			} 
		}
	//## Custom code
	//##
	}
}