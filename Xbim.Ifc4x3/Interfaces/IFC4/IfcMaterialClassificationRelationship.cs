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
namespace Xbim.Ifc4x3.MaterialResource
{
	public partial class @IfcMaterialClassificationRelationship : IIfcMaterialClassificationRelationship
	{

		[CrossSchemaAttribute(typeof(IIfcMaterialClassificationRelationship), 1)]
		IEnumerable<IIfcClassificationSelect> IIfcMaterialClassificationRelationship.MaterialClassifications 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<ExternalReferenceResource.IfcClassificationSelect, IIfcClassificationSelect>(MaterialClassifications);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcMaterialClassificationRelationship), 2)]
		IIfcMaterial IIfcMaterialClassificationRelationship.ClassifiedMaterial 
		{ 
			get
			{
				return ClassifiedMaterial;
			} 
			set
			{
				ClassifiedMaterial = value as IfcMaterial;
				
			}
		}
	//## Custom code
	//##
	}
}