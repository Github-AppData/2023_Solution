#include <stdio.h>
#include <stddef.h>

int main() {
    struct y_stack myStack;
    myStack.top_node = (void*)0;
    Initialize_y_stack(&myStack);

    Push(&myStack, 1);
    Push(&myStack, 2);
    Push(&myStack, 3);
    Push(&myStack, 4);
    Push(&myStack, 5);

    Pop(&myStack);
    Pop(&myStack);
    Pop(&myStack);
    Pop(&myStack);
    Pop(&myStack);

    return 0;
}