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
	public partial class @IfcRelAssignsToProduct : IIfcRelAssignsToProduct
	{

		[CrossSchemaAttribute(typeof(IIfcRelAssignsToProduct), 7)]
		IIfcProductSelect IIfcRelAssignsToProduct.RelatingProduct 
		{ 
			get
			{
				if (RelatingProduct == null) return null;
				var ifcproduct = RelatingProduct as IfcProduct;
				if (ifcproduct != null) 
					return ifcproduct;
				var ifctypeproduct = RelatingProduct as IfcTypeProduct;
				if (ifctypeproduct != null) 
					return ifctypeproduct;
				return null;
			} 
			set
			{
				if (value == null)
				{
					RelatingProduct = null;
					return;
				}	
				var ifcproduct = value as IfcProduct;
				if (ifcproduct != null) 
				{
					RelatingProduct = ifcproduct;
					return;
				}
				var ifctypeproduct = value as IfcTypeProduct;
				if (ifctypeproduct != null) 
				{
					RelatingProduct = ifctypeproduct;
					return;
				}
				
			}
		}
	//## Custom code
	//##
	}
}