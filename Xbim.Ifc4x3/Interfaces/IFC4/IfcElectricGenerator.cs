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
namespace Xbim.Ifc4x3.ElectricalDomain
{
	public partial class @IfcElectricGenerator : IIfcElectricGenerator
	{

		[CrossSchemaAttribute(typeof(IIfcElectricGenerator), 9)]
		Ifc4.Interfaces.IfcElectricGeneratorTypeEnum? IIfcElectricGenerator.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcElectricGeneratorTypeEnum.CHP:
						return Ifc4.Interfaces.IfcElectricGeneratorTypeEnum.CHP;
					case IfcElectricGeneratorTypeEnum.ENGINEGENERATOR:
						return Ifc4.Interfaces.IfcElectricGeneratorTypeEnum.ENGINEGENERATOR;
					case IfcElectricGeneratorTypeEnum.STANDALONE:
						return Ifc4.Interfaces.IfcElectricGeneratorTypeEnum.STANDALONE;
					case IfcElectricGeneratorTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcElectricGeneratorTypeEnum.USERDEFINED;
					case IfcElectricGeneratorTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcElectricGeneratorTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
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
					case Ifc4.Interfaces.IfcElectricGeneratorTypeEnum.CHP:
						PredefinedType = IfcElectricGeneratorTypeEnum.CHP;
						return;
					case Ifc4.Interfaces.IfcElectricGeneratorTypeEnum.ENGINEGENERATOR:
						PredefinedType = IfcElectricGeneratorTypeEnum.ENGINEGENERATOR;
						return;
					case Ifc4.Interfaces.IfcElectricGeneratorTypeEnum.STANDALONE:
						PredefinedType = IfcElectricGeneratorTypeEnum.STANDALONE;
						return;
					case Ifc4.Interfaces.IfcElectricGeneratorTypeEnum.USERDEFINED:
						PredefinedType = IfcElectricGeneratorTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcElectricGeneratorTypeEnum.NOTDEFINED:
						PredefinedType = IfcElectricGeneratorTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
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