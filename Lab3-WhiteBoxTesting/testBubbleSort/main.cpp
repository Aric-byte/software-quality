#include <cppunit/extensions/TestFactoryRegistry.h>
#include <cppunit/ui/text/TestRunner.h>
#include <cppunit/CompilerOutputter.h>
#include <iostream>

int main()
{
    CppUnit::TextUi::TestRunner runner;
    runner.addTest(CppUnit::TestFactoryRegistry::getRegistry().makeTest());
    runner.setOutputter(new CppUnit::CompilerOutputter(&runner.result(), std::cerr));
    bool ok = runner.run("", false, true, true);
    return ok ? 0 : 1;
}
