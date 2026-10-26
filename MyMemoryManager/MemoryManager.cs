using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace MyMemoryManager {
    internal class MemoryManager {

        private int[] memory;
        int header = 0;

        public MemoryManager(int memory_size) {
            memory = new int[memory_size];

            memory[0] = memory_size - 8;

            memory[1] = -1;
        }

        public int myalloc(int request_size) {
            int address = -1;
            int prev = -1;
            int ptr = header;

            while (ptr != -1) {
                // 헤더를 만들 여유 공간이 넘치면
                if (memory[ptr] > request_size + 8) 
                {
                    address = ptr + 8;

                    int new_ptr = ptr + request_size + 8;

                    memory[new_ptr] = memory[ptr] - request_size - 8;
                    memory[new_ptr + 1] = memory[ptr + 1];

                    if (prev == -1) 
                    {
                        header = new_ptr;
                    }

                    else 
                    {
                        memory[prev + 1] = new_ptr;
                    }

                    memory[ptr] = request_size;
                    break;
                }

                // 헤더를 만들 여유 공간을 포함한 공간과 같거나 적으면
                else if (memory[ptr] >= request_size) {
                    // 전체 다 할당.
                    address = ptr + 8;

                    if (prev == -1) 
                    {
                        header = memory[ptr + 1];
                    }
                    
                    else 
                    {
                        memory[prev + 1] = memory[ptr + 1];
                    }

                    memory[ptr] = request_size;
                    break;
                }

                // 요구 공간보다 여유 공간이 부족한 경우, 다음 블록으로 이동 시도.
                else {
                    prev = ptr;
                    ptr = memory[ptr + 1];
                }
            }

            return address; // 할당 성공 시 주소 반환, 할당 실패 시 -1 반환.
        }

        public void myfree(int start_address) {
            // 메모리 해제 로직
        }
    }
}
