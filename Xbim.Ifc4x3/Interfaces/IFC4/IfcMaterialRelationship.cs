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
namespace Xbim.Ifc4x3.MaterialResource
{
	public partial class @IfcMaterialRelationship : IIfcMaterialRelationship
	{

		[CrossSchemaAttribute(typeof(IIfcMaterialRelationship), 3)]
		IIfcMaterial IIfcMaterialRelationship.RelatingMaterial 
		{ 
			get
			{
				return RelatingMaterial;
			} 
			set
			{
				RelatingMaterial = value as IfcMaterial;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMaterialRelationship), 4)]
		IItemSet<IIfcMaterial> IIfcMaterialRelationship.RelatedMaterials 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcMaterial, IIfcMaterial>(RelatedMaterials);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcMaterialRelationship), 5)]
		Ifc4.MeasureResource.IfcLabel? IIfcMaterialRelationship.Expression 
		{ 
			get
			{
				if (!MaterialExpression.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(MaterialExpression.Value);
			} 
			set
			{
				MaterialExpression = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}