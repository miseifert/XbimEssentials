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
namespace Xbim.Ifc4x3.HvacDomain
{
	public partial class @IfcAirToAirHeatRecovery : IIfcAirToAirHeatRecovery
	{

		[CrossSchemaAttribute(typeof(IIfcAirToAirHeatRecovery), 9)]
		Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum? IIfcAirToAirHeatRecovery.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcAirToAirHeatRecoveryTypeEnum.FIXEDPLATECOUNTERFLOWEXCHANGER:
						return Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.FIXEDPLATECOUNTERFLOWEXCHANGER;
					case IfcAirToAirHeatRecoveryTypeEnum.FIXEDPLATECROSSFLOWEXCHANGER:
						return Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.FIXEDPLATECROSSFLOWEXCHANGER;
					case IfcAirToAirHeatRecoveryTypeEnum.FIXEDPLATEPARALLELFLOWEXCHANGER:
						return Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.FIXEDPLATEPARALLELFLOWEXCHANGER;
					case IfcAirToAirHeatRecoveryTypeEnum.ROTARYWHEEL:
						return Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.ROTARYWHEEL;
					case IfcAirToAirHeatRecoveryTypeEnum.RUNAROUNDCOILLOOP:
						return Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.RUNAROUNDCOILLOOP;
					case IfcAirToAirHeatRecoveryTypeEnum.HEATPIPE:
						return Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.HEATPIPE;
					case IfcAirToAirHeatRecoveryTypeEnum.TWINTOWERENTHALPYRECOVERYLOOPS:
						return Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.TWINTOWERENTHALPYRECOVERYLOOPS;
					case IfcAirToAirHeatRecoveryTypeEnum.THERMOSIPHONSEALEDTUBEHEATEXCHANGERS:
						return Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.THERMOSIPHONSEALEDTUBEHEATEXCHANGERS;
					case IfcAirToAirHeatRecoveryTypeEnum.THERMOSIPHONCOILTYPEHEATEXCHANGERS:
						return Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.THERMOSIPHONCOILTYPEHEATEXCHANGERS;
					case IfcAirToAirHeatRecoveryTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.USERDEFINED;
					case IfcAirToAirHeatRecoveryTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.FIXEDPLATECOUNTERFLOWEXCHANGER:
						PredefinedType = IfcAirToAirHeatRecoveryTypeEnum.FIXEDPLATECOUNTERFLOWEXCHANGER;
						return;
					case Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.FIXEDPLATECROSSFLOWEXCHANGER:
						PredefinedType = IfcAirToAirHeatRecoveryTypeEnum.FIXEDPLATECROSSFLOWEXCHANGER;
						return;
					case Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.FIXEDPLATEPARALLELFLOWEXCHANGER:
						PredefinedType = IfcAirToAirHeatRecoveryTypeEnum.FIXEDPLATEPARALLELFLOWEXCHANGER;
						return;
					case Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.ROTARYWHEEL:
						PredefinedType = IfcAirToAirHeatRecoveryTypeEnum.ROTARYWHEEL;
						return;
					case Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.RUNAROUNDCOILLOOP:
						PredefinedType = IfcAirToAirHeatRecoveryTypeEnum.RUNAROUNDCOILLOOP;
						return;
					case Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.HEATPIPE:
						PredefinedType = IfcAirToAirHeatRecoveryTypeEnum.HEATPIPE;
						return;
					case Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.TWINTOWERENTHALPYRECOVERYLOOPS:
						PredefinedType = IfcAirToAirHeatRecoveryTypeEnum.TWINTOWERENTHALPYRECOVERYLOOPS;
						return;
					case Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.THERMOSIPHONSEALEDTUBEHEATEXCHANGERS:
						PredefinedType = IfcAirToAirHeatRecoveryTypeEnum.THERMOSIPHONSEALEDTUBEHEATEXCHANGERS;
						return;
					case Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.THERMOSIPHONCOILTYPEHEATEXCHANGERS:
						PredefinedType = IfcAirToAirHeatRecoveryTypeEnum.THERMOSIPHONCOILTYPEHEATEXCHANGERS;
						return;
					case Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.USERDEFINED:
						PredefinedType = IfcAirToAirHeatRecoveryTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcAirToAirHeatRecoveryTypeEnum.NOTDEFINED:
						PredefinedType = IfcAirToAirHeatRecoveryTypeEnum.NOTDEFINED;
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