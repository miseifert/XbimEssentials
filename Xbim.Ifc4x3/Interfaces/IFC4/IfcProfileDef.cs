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
namespace Xbim.Ifc4x3.ProfileResource
{
	public partial class @IfcProfileDef : IIfcProfileDef
	{

		[CrossSchemaAttribute(typeof(IIfcProfileDef), 1)]
		Ifc4.Interfaces.IfcProfileTypeEnum IIfcProfileDef.ProfileType 
		{ 
			get
			{
				//## Custom code to handle enumeration of ProfileType
				//##
				switch (ProfileType)
				{
					case IfcProfileTypeEnum.CURVE:
						return Ifc4.Interfaces.IfcProfileTypeEnum.CURVE;
					case IfcProfileTypeEnum.AREA:
						return Ifc4.Interfaces.IfcProfileTypeEnum.AREA;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of ProfileType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcProfileTypeEnum.CURVE:
						ProfileType = IfcProfileTypeEnum.CURVE;
						return;
					case Ifc4.Interfaces.IfcProfileTypeEnum.AREA:
						ProfileType = IfcProfileTypeEnum.AREA;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcProfileDef), 2)]
		Ifc4.MeasureResource.IfcLabel? IIfcProfileDef.ProfileName 
		{ 
			get
			{
				if (!ProfileName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(ProfileName.Value);
			} 
			set
			{
				ProfileName = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcProfileDef.HasExternalReference 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
		IEnumerable<IIfcProfileProperties> IIfcProfileDef.HasProperties 
		{ 
			get
			{
				return Model.Instances.Where<IIfcProfileProperties>(e => (e.ProfileDefinition as IfcProfileDef) == this, "ProfileDefinition", this);
			} 
		}
	//## Custom code
	//##
	}
}