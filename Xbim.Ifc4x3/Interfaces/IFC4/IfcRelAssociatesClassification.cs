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
namespace Xbim.Ifc4x3.Kernel
{
	public partial class @IfcRelAssociatesClassification : IIfcRelAssociatesClassification
	{

		[CrossSchemaAttribute(typeof(IIfcRelAssociatesClassification), 6)]
		IIfcClassificationSelect IIfcRelAssociatesClassification.RelatingClassification 
		{ 
			get
			{
				if (RelatingClassification == null) return null;
				var ifcclassification = RelatingClassification as ExternalReferenceResource.IfcClassification;
				if (ifcclassification != null) 
					return ifcclassification;
				var ifcclassificationreference = RelatingClassification as ExternalReferenceResource.IfcClassificationReference;
				if (ifcclassificationreference != null) 
					return ifcclassificationreference;
				return null;
			} 
			set
			{
				if (value == null)
				{
					RelatingClassification = null;
					return;
				}	
				var ifcclassification = value as ExternalReferenceResource.IfcClassification;
				if (ifcclassification != null) 
				{
					RelatingClassification = ifcclassification;
					return;
				}
				var ifcclassificationreference = value as ExternalReferenceResource.IfcClassificationReference;
				if (ifcclassificationreference != null) 
				{
					RelatingClassification = ifcclassificationreference;
					return;
				}
				
			}
		}
	//## Custom code
	//##
	}
}