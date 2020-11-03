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
namespace Xbim.Ifc4x3.ProductExtension
{
	public partial class @IfcGeographicElementType : IIfcGeographicElementType
	{

		[CrossSchemaAttribute(typeof(IIfcGeographicElementType), 10)]
		Ifc4.Interfaces.IfcGeographicElementTypeEnum IIfcGeographicElementType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcGeographicElementTypeEnum.TERRAIN:
						return Ifc4.Interfaces.IfcGeographicElementTypeEnum.TERRAIN;
					case IfcGeographicElementTypeEnum.SOIL_BORING_POINT:
						//## Handle translation of SOIL_BORING_POINT member from IfcGeographicElementTypeEnum in property PredefinedType
						//TODO: Handle translation of SOIL_BORING_POINT member from IfcGeographicElementTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcGeographicElementTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcGeographicElementTypeEnum.USERDEFINED;
					case IfcGeographicElementTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcGeographicElementTypeEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcGeographicElementTypeEnum.TERRAIN:
						PredefinedType = IfcGeographicElementTypeEnum.TERRAIN;
						return;
					case Ifc4.Interfaces.IfcGeographicElementTypeEnum.USERDEFINED:
						PredefinedType = IfcGeographicElementTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcGeographicElementTypeEnum.NOTDEFINED:
						PredefinedType = IfcGeographicElementTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}