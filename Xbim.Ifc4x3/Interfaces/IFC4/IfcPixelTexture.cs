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
namespace Xbim.Ifc4x3.PresentationAppearanceResource
{
	public partial class @IfcPixelTexture : IIfcPixelTexture
	{

		[CrossSchemaAttribute(typeof(IIfcPixelTexture), 6)]
		Ifc4.MeasureResource.IfcInteger IIfcPixelTexture.Width 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcInteger(Width);
			} 
			set
			{
				Width = new MeasureResource.IfcInteger(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPixelTexture), 7)]
		Ifc4.MeasureResource.IfcInteger IIfcPixelTexture.Height 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcInteger(Height);
			} 
			set
			{
				Height = new MeasureResource.IfcInteger(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPixelTexture), 8)]
		Ifc4.MeasureResource.IfcInteger IIfcPixelTexture.ColourComponents 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcInteger(ColourComponents);
			} 
			set
			{
				ColourComponents = new MeasureResource.IfcInteger(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPixelTexture), 9)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcBinary> IIfcPixelTexture.Pixel 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcBinary, Ifc4.MeasureResource.IfcBinary>(Pixel, 
					s => new Ifc4.MeasureResource.IfcBinary(s), 
					t => new MeasureResource.IfcBinary(t));
			} 
		}
	//## Custom code
	//##
	}
}