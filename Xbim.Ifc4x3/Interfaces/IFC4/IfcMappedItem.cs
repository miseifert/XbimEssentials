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
namespace Xbim.Ifc4x3.GeometryResource
{
	public partial class @IfcMappedItem : IIfcMappedItem
	{

		[CrossSchemaAttribute(typeof(IIfcMappedItem), 1)]
		IIfcRepresentationMap IIfcMappedItem.MappingSource 
		{ 
			get
			{
				return MappingSource;
			} 
			set
			{
				MappingSource = value as IfcRepresentationMap;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMappedItem), 2)]
		IIfcCartesianTransformationOperator IIfcMappedItem.MappingTarget 
		{ 
			get
			{
				return MappingTarget;
			} 
			set
			{
				MappingTarget = value as IfcCartesianTransformationOperator;
				
			}
		}
	//## Custom code
	//##
	}
}