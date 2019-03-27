#include "DllInterface.h"

void(*Debug::Log)(char* message, int iSize);

void _DllExport InitCSharpDelegate(void(*Log)(char* message, int iSize))
{
	Debug::Log = Log;
	UnityLog("Cpp Message:Log has initialized");
}

float _DllExport GetDistance(float x1, float y1, float x2, float y2)
{
	return sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}
