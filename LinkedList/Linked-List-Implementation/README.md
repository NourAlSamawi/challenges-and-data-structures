# Linked List Merge Sorted Lists

## Problem Domain
Merge two sorted linked lists into one sorted linked list.

## Inputs and Expected Outputs
| List 1            | List 2            | Merged List                    |
|-------------------|-------------------|--------------------------------|
| Head -> 1 -> 3 -> 5 -> Null | Head -> 2 -> 4 -> 6 -> Null | Head -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> Null |
| Head -> 5 -> 10 -> 15 -> Null | Head -> 2 -> 3 -> 20 -> Null | Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null |

## Edge Cases
- Both lists are empty.
- One list is empty.
- Lists have different lengths.

## Visual
(Include your whiteboard image here)

## Algorithm
- Initialize two pointers, `current1` and `current2`, at the head of `list1` and `list2`.
- Traverse through both lists, appending the smaller value to the merged list.
- Continue until all elements are merged.

## Real Code
(Include your code here)

## Big O Time/Space Complexity
- **Time Complexity**: O(n + m) where `n` and `m` are the lengths of the two lists.
- **Space Complexity**: O(n + m) for the merged list.

## Console Output
(Include a screenshot of your console output here)
