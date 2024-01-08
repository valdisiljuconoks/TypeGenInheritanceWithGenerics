/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { IStructuralEquatable } from './IStructuralEquatable.generated';
import { IStructuralComparable } from './IStructuralComparable.generated';
import { ITupleInternal } from './ITupleInternal.generated';
import { ITuple } from './ITuple.generated';

export class Tuple<T1, T2> implements IStructuralEquatable, IStructuralComparable, ITupleInternal, ITuple {
  item1: T1;
  item2: T2;
}
