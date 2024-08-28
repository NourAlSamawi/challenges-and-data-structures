# Linked List Merge Sorted Lists

## Problem Domain
Implement a method to merge two sorted linked lists into a single sorted linked list.

## Inputs and Expected Outputs
- Inputs: Two sorted linked lists.
- Outputs: A single merged sorted linked list.

## Edge Cases
- One or both lists being empty.
- Handling of equal values.

## Visual
List 1: Head -> 1 -> 3 -> 5 -> Null
List 2: Head -> 2 -> 4 -> 6 -> Null
Merged List: Head -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> Null


## Algorithm
1. Initialize two pointers for the heads of both lists.
2. Compare the nodes and append the smaller node to the merged list.
3. Move the pointer of the appended node forward.
4. Continue until one of the lists is exhausted.
5. Append the remaining nodes of the non-exhausted list.

## Real Code
Included in the files.

## Big O Time/Space Complexity
- Time: O(n + m) where n and m are the lengths of the two lists.
- Space: O(n + m) for the new merged list.

## Console Output Screenshot
![Console Output](screenshot.png)
