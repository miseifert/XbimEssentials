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
namespace Xbim.Ifc4x3.GeometryResource
{
	public partial class @IfcElementarySurface : IIfcElementarySurface
	{

		[CrossSchemaAttribute(typeof(IIfcElementarySurface), 1)]
		IIfcAxis2Placement3D IIfcElementarySurface.Position 
		{ 
			get
			{
				return Position;
			} 
			set
			{
				Position = value as IfcAxis2Placement3D;
				
			}
		}
	//## Custom code
	//##
	}
}