CXX ?= g++
CXXFLAGS ?= -Wall -Wextra -std=c++11
SRCS = bsort/BubbleSort.cpp testBubbleSort/BubbleSortTest.cpp testBubbleSort/main.cpp

testBubbleSort/testBubbleSort: $(SRCS) bsort/BubbleSort.h testBubbleSort/BubbleSortTest.h
	$(CXX) $(CXXFLAGS) $(SRCS) -o $@ -lcppunit

test: testBubbleSort/testBubbleSort
	./testBubbleSort/testBubbleSort

clean:
	rm -f testBubbleSort/testBubbleSort

.PHONY: test clean
