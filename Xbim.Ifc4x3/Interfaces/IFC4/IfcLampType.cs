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
namespace Xbim.Ifc4x3.ElectricalDomain
{
	public partial class @IfcLampType : IIfcLampType
	{

		[CrossSchemaAttribute(typeof(IIfcLampType), 10)]
		Ifc4.Interfaces.IfcLampTypeEnum IIfcLampType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcLampTypeEnum.COMPACTFLUORESCENT:
						return Ifc4.Interfaces.IfcLampTypeEnum.COMPACTFLUORESCENT;
					case IfcLampTypeEnum.FLUORESCENT:
						return Ifc4.Interfaces.IfcLampTypeEnum.FLUORESCENT;
					case IfcLampTypeEnum.HALOGEN:
						return Ifc4.Interfaces.IfcLampTypeEnum.HALOGEN;
					case IfcLampTypeEnum.HIGHPRESSUREMERCURY:
						return Ifc4.Interfaces.IfcLampTypeEnum.HIGHPRESSUREMERCURY;
					case IfcLampTypeEnum.HIGHPRESSURESODIUM:
						return Ifc4.Interfaces.IfcLampTypeEnum.HIGHPRESSURESODIUM;
					case IfcLampTypeEnum.LED:
						return Ifc4.Interfaces.IfcLampTypeEnum.LED;
					case IfcLampTypeEnum.METALHALIDE:
						return Ifc4.Interfaces.IfcLampTypeEnum.METALHALIDE;
					case IfcLampTypeEnum.OLED:
						return Ifc4.Interfaces.IfcLampTypeEnum.OLED;
					case IfcLampTypeEnum.TUNGSTENFILAMENT:
						return Ifc4.Interfaces.IfcLampTypeEnum.TUNGSTENFILAMENT;
					case IfcLampTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcLampTypeEnum.USERDEFINED;
					case IfcLampTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcLampTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcLampTypeEnum.COMPACTFLUORESCENT:
						PredefinedType = IfcLampTypeEnum.COMPACTFLUORESCENT;
						return;
					case Ifc4.Interfaces.IfcLampTypeEnum.FLUORESCENT:
						PredefinedType = IfcLampTypeEnum.FLUORESCENT;
						return;
					case Ifc4.Interfaces.IfcLampTypeEnum.HALOGEN:
						PredefinedType = IfcLampTypeEnum.HALOGEN;
						return;
					case Ifc4.Interfaces.IfcLampTypeEnum.HIGHPRESSUREMERCURY:
						PredefinedType = IfcLampTypeEnum.HIGHPRESSUREMERCURY;
						return;
					case Ifc4.Interfaces.IfcLampTypeEnum.HIGHPRESSURESODIUM:
						PredefinedType = IfcLampTypeEnum.HIGHPRESSURESODIUM;
						return;
					case Ifc4.Interfaces.IfcLampTypeEnum.LED:
						PredefinedType = IfcLampTypeEnum.LED;
						return;
					case Ifc4.Interfaces.IfcLampTypeEnum.METALHALIDE:
						PredefinedType = IfcLampTypeEnum.METALHALIDE;
						return;
					case Ifc4.Interfaces.IfcLampTypeEnum.OLED:
						PredefinedType = IfcLampTypeEnum.OLED;
						return;
					case Ifc4.Interfaces.IfcLampTypeEnum.TUNGSTENFILAMENT:
						PredefinedType = IfcLampTypeEnum.TUNGSTENFILAMENT;
						return;
					case Ifc4.Interfaces.IfcLampTypeEnum.USERDEFINED:
						PredefinedType = IfcLampTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcLampTypeEnum.NOTDEFINED:
						PredefinedType = IfcLampTypeEnum.NOTDEFINED;
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