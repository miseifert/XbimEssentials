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
	public partial class @IfcRationalBSplineCurveWithKnots : IIfcRationalBSplineCurveWithKnots
	{

		[CrossSchemaAttribute(typeof(IIfcRationalBSplineCurveWithKnots), 9)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcReal> IIfcRationalBSplineCurveWithKnots.WeightsData 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcReal, Ifc4.MeasureResource.IfcReal>(WeightsData, 
					s => new Ifc4.MeasureResource.IfcReal(s), 
					t => new MeasureResource.IfcReal(t));
			} 
		}
		List<Xbim.Ifc4.MeasureResource.IfcReal> IIfcRationalBSplineCurveWithKnots.Weights 
		{
			get 
			{
				//## Getter for Weights in an interface
				//TODO: Implement getter for derived attribute Weights in an interface
				throw new System.NotImplementedException();
				//##
			}
		}

	//## Custom code
	//##
	}
}