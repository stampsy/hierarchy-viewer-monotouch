TARGET_NAME = iOSHierarchyViewer
LIB_NAME = libiOSHierarchyViewer_fat
BTOUCH=/Developer/MonoTouch/usr/bin/btouch

all: lib$(TARGET_NAME).dll

$(TARGET): FORCE

lib$(TARGET_NAME).dll:  ApiDefinition.cs $(LIB_NAME).linkwith.cs Makefile  $(LIB_NAME).a
	$(BTOUCH) -e ApiDefinition.cs -x=$(LIB_NAME).linkwith.cs --out=$@ --link-with=$(LIB_NAME).a,$(LIB_NAME).a

clean:
	-rm -f *.a *.dll *.jar

FORCE: