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
	public partial class @IfcDuctSilencerType : IIfcDuctSilencerType
	{

		[CrossSchemaAttribute(typeof(IIfcDuctSilencerType), 10)]
		Ifc4.Interfaces.IfcDuctSilencerTypeEnum IIfcDuctSilencerType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcDuctSilencerTypeEnum.FLATOVAL:
						return Ifc4.Interfaces.IfcDuctSilencerTypeEnum.FLATOVAL;
					case IfcDuctSilencerTypeEnum.RECTANGULAR:
						return Ifc4.Interfaces.IfcDuctSilencerTypeEnum.RECTANGULAR;
					case IfcDuctSilencerTypeEnum.ROUND:
						return Ifc4.Interfaces.IfcDuctSilencerTypeEnum.ROUND;
					case IfcDuctSilencerTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcDuctSilencerTypeEnum.USERDEFINED;
					case IfcDuctSilencerTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDuctSilencerTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcDuctSilencerTypeEnum.FLATOVAL:
						PredefinedType = IfcDuctSilencerTypeEnum.FLATOVAL;
						return;
					case Ifc4.Interfaces.IfcDuctSilencerTypeEnum.RECTANGULAR:
						PredefinedType = IfcDuctSilencerTypeEnum.RECTANGULAR;
						return;
					case Ifc4.Interfaces.IfcDuctSilencerTypeEnum.ROUND:
						PredefinedType = IfcDuctSilencerTypeEnum.ROUND;
						return;
					case Ifc4.Interfaces.IfcDuctSilencerTypeEnum.USERDEFINED:
						PredefinedType = IfcDuctSilencerTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcDuctSilencerTypeEnum.NOTDEFINED:
						PredefinedType = IfcDuctSilencerTypeEnum.NOTDEFINED;
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