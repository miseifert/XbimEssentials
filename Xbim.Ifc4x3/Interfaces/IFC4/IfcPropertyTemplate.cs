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
namespace Xbim.Ifc4x3.Kernel
{
	public partial class @IfcPropertyTemplate : IIfcPropertyTemplate
	{
		IEnumerable<IIfcComplexPropertyTemplate> IIfcPropertyTemplate.PartOfComplexTemplate 
		{ 
			get
			{
				return Model.Instances.Where<IIfcComplexPropertyTemplate>(e => e.HasPropertyTemplates != null &&  e.HasPropertyTemplates.Contains(this), "HasPropertyTemplates", this);
			} 
		}
		IEnumerable<IIfcPropertySetTemplate> IIfcPropertyTemplate.PartOfPsetTemplate 
		{ 
			get
			{
				return Model.Instances.Where<IIfcPropertySetTemplate>(e => e.HasPropertyTemplates != null &&  e.HasPropertyTemplates.Contains(this), "HasPropertyTemplates", this);
			} 
		}
	//## Custom code
	//##
	}
}