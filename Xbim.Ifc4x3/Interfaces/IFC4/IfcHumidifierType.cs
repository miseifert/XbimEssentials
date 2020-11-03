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
namespace Xbim.Ifc4x3.HvacDomain
{
	public partial class @IfcHumidifierType : IIfcHumidifierType
	{

		[CrossSchemaAttribute(typeof(IIfcHumidifierType), 10)]
		Ifc4.Interfaces.IfcHumidifierTypeEnum IIfcHumidifierType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcHumidifierTypeEnum.STEAMINJECTION:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.STEAMINJECTION;
					case IfcHumidifierTypeEnum.ADIABATICAIRWASHER:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICAIRWASHER;
					case IfcHumidifierTypeEnum.ADIABATICPAN:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICPAN;
					case IfcHumidifierTypeEnum.ADIABATICWETTEDELEMENT:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICWETTEDELEMENT;
					case IfcHumidifierTypeEnum.ADIABATICATOMIZING:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICATOMIZING;
					case IfcHumidifierTypeEnum.ADIABATICULTRASONIC:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICULTRASONIC;
					case IfcHumidifierTypeEnum.ADIABATICRIGIDMEDIA:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICRIGIDMEDIA;
					case IfcHumidifierTypeEnum.ADIABATICCOMPRESSEDAIRNOZZLE:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICCOMPRESSEDAIRNOZZLE;
					case IfcHumidifierTypeEnum.ASSISTEDELECTRIC:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.ASSISTEDELECTRIC;
					case IfcHumidifierTypeEnum.ASSISTEDNATURALGAS:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.ASSISTEDNATURALGAS;
					case IfcHumidifierTypeEnum.ASSISTEDPROPANE:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.ASSISTEDPROPANE;
					case IfcHumidifierTypeEnum.ASSISTEDBUTANE:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.ASSISTEDBUTANE;
					case IfcHumidifierTypeEnum.ASSISTEDSTEAM:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.ASSISTEDSTEAM;
					case IfcHumidifierTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.USERDEFINED;
					case IfcHumidifierTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcHumidifierTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.STEAMINJECTION:
						PredefinedType = IfcHumidifierTypeEnum.STEAMINJECTION;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICAIRWASHER:
						PredefinedType = IfcHumidifierTypeEnum.ADIABATICAIRWASHER;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICPAN:
						PredefinedType = IfcHumidifierTypeEnum.ADIABATICPAN;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICWETTEDELEMENT:
						PredefinedType = IfcHumidifierTypeEnum.ADIABATICWETTEDELEMENT;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICATOMIZING:
						PredefinedType = IfcHumidifierTypeEnum.ADIABATICATOMIZING;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICULTRASONIC:
						PredefinedType = IfcHumidifierTypeEnum.ADIABATICULTRASONIC;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICRIGIDMEDIA:
						PredefinedType = IfcHumidifierTypeEnum.ADIABATICRIGIDMEDIA;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.ADIABATICCOMPRESSEDAIRNOZZLE:
						PredefinedType = IfcHumidifierTypeEnum.ADIABATICCOMPRESSEDAIRNOZZLE;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.ASSISTEDELECTRIC:
						PredefinedType = IfcHumidifierTypeEnum.ASSISTEDELECTRIC;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.ASSISTEDNATURALGAS:
						PredefinedType = IfcHumidifierTypeEnum.ASSISTEDNATURALGAS;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.ASSISTEDPROPANE:
						PredefinedType = IfcHumidifierTypeEnum.ASSISTEDPROPANE;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.ASSISTEDBUTANE:
						PredefinedType = IfcHumidifierTypeEnum.ASSISTEDBUTANE;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.ASSISTEDSTEAM:
						PredefinedType = IfcHumidifierTypeEnum.ASSISTEDSTEAM;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.USERDEFINED:
						PredefinedType = IfcHumidifierTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcHumidifierTypeEnum.NOTDEFINED:
						PredefinedType = IfcHumidifierTypeEnum.NOTDEFINED;
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