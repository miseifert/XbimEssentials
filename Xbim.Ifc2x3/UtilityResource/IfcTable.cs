// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ConstraintResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.UtilityResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.UtilityResource
{
	[ExpressType("IfcTable", 377)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTable : PersistEntity, IInstantiableEntity, IfcMetricValueSelect, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcTable>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTable(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_rows = new ItemSet<IfcTableRow>( this, 0,  2);
		}

		#region Explicit attribute fields
		private string _name;
		private readonly ItemSet<IfcTableRow> _rows;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public string @Name 
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
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 2)]
		public IItemSet<IfcTableRow> @Rows 
		{ 
			get 
			{
				if(_activated) return _rows;
				Activate();
				return _rows;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public long @NumberOfCellsInRow 
		{
			get 
			{
				//## Getter for NumberOfCellsInRow
			    return Rows != null
			        ? Rows[0].RowCells.Count
			        : 0;
			    //##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public long @NumberOfHeadings 
		{
			get 
			{
				//## Getter for NumberOfHeadings
			    return Rows.Count(r => r.IsHeading);
			    //##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public long @NumberOfDataRows 
		{
			get 
			{
				//## Getter for NumberOfDataRows
                return Rows.Count(r => !r.IsHeading);
				//##
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
					_rows.InternalAdd((IfcTableRow)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTable other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Rows)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Rows)
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