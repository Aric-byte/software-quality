#include <cppunit/BriefTestProgressListener.h>
#include <cppunit/CompilerOutputter.h>
#include <cppunit/TestResult.h>
#include <cppunit/TestResultCollector.h>
#include <cppunit/TestRunner.h>
#include <cppunit/extensions/TestFactoryRegistry.h>
#include <iostream>

int main()
{
    CppUnit::TestResult controller;
    CppUnit::TestResultCollector collector;
    controller.addListener(&collector);

    // 逐条打印每个测试用例的名称与结果
    CppUnit::BriefTestProgressListener progress;
    controller.addListener(&progress);

    CppUnit::TestRunner runner;
    runner.addTest(CppUnit::TestFactoryRegistry::getRegistry().makeTest());
    runner.run(controller);

    CppUnit::CompilerOutputter outputter(&collector, std::cout);
    outputter.write();
    return collector.wasSuccessful() ? 0 : 1;
}
