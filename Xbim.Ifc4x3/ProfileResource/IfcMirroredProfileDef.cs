// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.ProfileResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.ProfileResource
{
	[ExpressType("IfcMirroredProfileDef", 1215)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMirroredProfileDef : IfcDerivedProfileDef, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcMirroredProfileDef>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMirroredProfileDef(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}


		#region Overriding attributes
		[EntityAttribute(4, EntityAttributeState.DerivedOverride, EntityAttributeType.Class, EntityAttributeType.None, null, null, 0)]
		public override IfcCartesianTransformationOperator2D @Operator 
		{
			get 
			{
				//## Overriding derived attribute Operator getter
				//TODO: Implement overriding derived attribute Operator getter
				throw new NotImplementedException();
				//##
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property Operator in IfcMirroredProfileDef"); 
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
        public bool Equals(@IfcMirroredProfileDef other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ParentProfile != null)
					yield return @ParentProfile;
				if (@Operator != null)
					yield return @Operator;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}