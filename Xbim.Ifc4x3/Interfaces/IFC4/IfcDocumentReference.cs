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
namespace Xbim.Ifc4x3.ExternalReferenceResource
{
	public partial class @IfcDocumentReference : IIfcDocumentReference
	{

		[CrossSchemaAttribute(typeof(IIfcDocumentReference), 4)]
		Ifc4.MeasureResource.IfcText? IIfcDocumentReference.Description 
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

		[CrossSchemaAttribute(typeof(IIfcDocumentReference), 5)]
		IIfcDocumentInformation IIfcDocumentReference.ReferencedDocument 
		{ 
			get
			{
				return ReferencedDocument;
			} 
			set
			{
				ReferencedDocument = value as IfcDocumentInformation;
				
			}
		}
		IEnumerable<IIfcRelAssociatesDocument> IIfcDocumentReference.DocumentRefForObjects 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesDocument>(e => (e.RelatingDocument as IfcDocumentReference) == this, "RelatingDocument", this);
			} 
		}
	//## Custom code
	//##
	}
}