// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Kernel;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IfcPropertySetDefinition", 97)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPropertySetDefinition : IfcPropertyDefinition, IEquatable<@IfcPropertySetDefinition>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertySetDefinition(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}




		#region Inverse attributes
		[InverseProperty("RelatingPropertyDefinition")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 6)]
		public IEnumerable<IfcRelDefinesByProperties> @PropertyDefinitionOf 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByProperties>(e => Equals(e.RelatingPropertyDefinition), "RelatingPropertyDefinition", this);
			} 
		}
		[InverseProperty("HasPropertySets")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 7)]
		public IEnumerable<IfcTypeObject> @DefinesType 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTypeObject>(e => e.HasPropertySets != null &&  e.HasPropertySets.Contains(this), "HasPropertySets", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertySetDefinition other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}