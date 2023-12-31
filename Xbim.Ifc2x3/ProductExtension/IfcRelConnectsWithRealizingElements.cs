// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.ProductExtension;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IfcRelConnectsWithRealizingElements", 313)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsWithRealizingElements : IfcRelConnectsElements, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelConnectsWithRealizingElements>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsWithRealizingElements(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_realizingElements = new ItemSet<IfcElement>( this, 0,  8);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcElement> _realizingElements;
		private IfcLabel? _connectionType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 8)]
		public IItemSet<IfcElement> @RealizingElements 
		{ 
			get 
			{
				if(_activated) return _realizingElements;
				Activate();
				return _realizingElements;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcLabel? @ConnectionType 
		{ 
			get 
			{
				if(_activated) return _connectionType;
				Activate();
				return _connectionType;
			} 
			set
			{
				SetValue( v =>  _connectionType = v, _connectionType, value,  "ConnectionType", 9);
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
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_realizingElements.InternalAdd((IfcElement)value.EntityVal);
					return;
				case 8: 
					_connectionType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelConnectsWithRealizingElements other)
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
				if (@ConnectionGeometry != null)
					yield return @ConnectionGeometry;
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedElement != null)
					yield return @RelatedElement;
				foreach(var entity in @RealizingElements)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedElement != null)
					yield return @RelatedElement;
				foreach(var entity in @RealizingElements)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}