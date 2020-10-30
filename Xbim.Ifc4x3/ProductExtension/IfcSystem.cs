// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.SharedInfrastructureElements;
using Xbim.Ifc4x3.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.ProductExtension;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.ProductExtension
{
	[ExpressType("IfcSystem", 229)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSystem : IfcGroup, IInstantiableEntity, IfcSpatialReferenceSelect, IContainsEntityReferences, IEquatable<@IfcSystem>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSystem(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}




		#region Inverse attributes
		[InverseProperty("RelatingSystem")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 18)]
		public IEnumerable<IfcRelServicesBuildings> @ServicesBuildings 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelServicesBuildings>(e => Equals(e.RelatingSystem), "RelatingSystem", this);
			} 
		}
		[InverseProperty("RelatedElements")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 19)]
		public IEnumerable<IfcRelReferencedInSpatialStructure> @ServicesFacilities 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelReferencedInSpatialStructure>(e => e.RelatedElements != null &&  e.RelatedElements.Contains(this), "RelatedElements", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSystem other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}