// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurveStyleFont
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurveStyleFont : IIfcPresentationItem, IfcCurveStyleFontSelect
	{
		IfcLabel? @Name { get;  set; }
		IItemSet<IIfcCurveStyleFontPattern> @PatternList { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcCurveStyleFont", 223)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveStyleFont : IfcPresentationItem, IInstantiableEntity, IIfcCurveStyleFont, IContainsEntityReferences, IEquatable<@IfcCurveStyleFont>
	{
		#region IIfcCurveStyleFont explicit implementation
		IfcLabel? IIfcCurveStyleFont.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IItemSet<IIfcCurveStyleFontPattern> IIfcCurveStyleFont.PatternList { 
			get { return new Common.Collections.ProxyItemSet<IfcCurveStyleFontPattern, IIfcCurveStyleFontPattern>( @PatternList); } 
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveStyleFont(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_patternList = new ItemSet<IfcCurveStyleFontPattern>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private readonly ItemSet<IfcCurveStyleFontPattern> _patternList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 2)]
		public IItemSet<IfcCurveStyleFontPattern> @PatternList 
		{ 
			get 
			{
				if(_activated) return _patternList;
				Activate();
				return _patternList;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_patternList.InternalAdd((IfcCurveStyleFontPattern)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurveStyleFont other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @PatternList)
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