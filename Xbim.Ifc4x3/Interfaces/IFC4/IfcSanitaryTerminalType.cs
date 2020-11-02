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
namespace Xbim.Ifc4x3.PlumbingFireProtectionDomain
{
	public partial class @IfcSanitaryTerminalType : IIfcSanitaryTerminalType
	{

		[CrossSchemaAttribute(typeof(IIfcSanitaryTerminalType), 10)]
		Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum IIfcSanitaryTerminalType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcSanitaryTerminalTypeEnum.BATH:
						return Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.BATH;
					case IfcSanitaryTerminalTypeEnum.BIDET:
						return Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.BIDET;
					case IfcSanitaryTerminalTypeEnum.CISTERN:
						return Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.CISTERN;
					case IfcSanitaryTerminalTypeEnum.SHOWER:
						return Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.SHOWER;
					case IfcSanitaryTerminalTypeEnum.SINK:
						return Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.SINK;
					case IfcSanitaryTerminalTypeEnum.SANITARYFOUNTAIN:
						return Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.SANITARYFOUNTAIN;
					case IfcSanitaryTerminalTypeEnum.TOILETPAN:
						return Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.TOILETPAN;
					case IfcSanitaryTerminalTypeEnum.URINAL:
						return Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.URINAL;
					case IfcSanitaryTerminalTypeEnum.WASHHANDBASIN:
						return Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.WASHHANDBASIN;
					case IfcSanitaryTerminalTypeEnum.WCSEAT:
						return Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.WCSEAT;
					case IfcSanitaryTerminalTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.USERDEFINED;
					case IfcSanitaryTerminalTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.BATH:
						PredefinedType = IfcSanitaryTerminalTypeEnum.BATH;
						return;
					case Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.BIDET:
						PredefinedType = IfcSanitaryTerminalTypeEnum.BIDET;
						return;
					case Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.CISTERN:
						PredefinedType = IfcSanitaryTerminalTypeEnum.CISTERN;
						return;
					case Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.SHOWER:
						PredefinedType = IfcSanitaryTerminalTypeEnum.SHOWER;
						return;
					case Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.SINK:
						PredefinedType = IfcSanitaryTerminalTypeEnum.SINK;
						return;
					case Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.SANITARYFOUNTAIN:
						PredefinedType = IfcSanitaryTerminalTypeEnum.SANITARYFOUNTAIN;
						return;
					case Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.TOILETPAN:
						PredefinedType = IfcSanitaryTerminalTypeEnum.TOILETPAN;
						return;
					case Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.URINAL:
						PredefinedType = IfcSanitaryTerminalTypeEnum.URINAL;
						return;
					case Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.WASHHANDBASIN:
						PredefinedType = IfcSanitaryTerminalTypeEnum.WASHHANDBASIN;
						return;
					case Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.WCSEAT:
						PredefinedType = IfcSanitaryTerminalTypeEnum.WCSEAT;
						return;
					case Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.USERDEFINED:
						PredefinedType = IfcSanitaryTerminalTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcSanitaryTerminalTypeEnum.NOTDEFINED:
						PredefinedType = IfcSanitaryTerminalTypeEnum.NOTDEFINED;
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