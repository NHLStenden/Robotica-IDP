# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.15

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Remove some rules from gmake that .SUFFIXES does not remove.
SUFFIXES =

.SUFFIXES: .hpux_make_needs_suffix_list


# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /mnt/ssd/Apps/clion-2019.3.5/bin/cmake/linux/bin/cmake

# The command to remove a file.
RM = /mnt/ssd/Apps/clion-2019.3.5/bin/cmake/linux/bin/cmake -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp/cmake-build-debug

# Include any dependencies generated for this target.
include CMakeFiles/chatter.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/chatter.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/chatter.dir/flags.make

CMakeFiles/chatter.dir/main.cpp.o: CMakeFiles/chatter.dir/flags.make
CMakeFiles/chatter.dir/main.cpp.o: ../main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/chatter.dir/main.cpp.o"
	/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/chatter.dir/main.cpp.o -c /mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp/main.cpp

CMakeFiles/chatter.dir/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/chatter.dir/main.cpp.i"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp/main.cpp > CMakeFiles/chatter.dir/main.cpp.i

CMakeFiles/chatter.dir/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/chatter.dir/main.cpp.s"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp/main.cpp -o CMakeFiles/chatter.dir/main.cpp.s

# Object files for target chatter
chatter_OBJECTS = \
"CMakeFiles/chatter.dir/main.cpp.o"

# External object files for target chatter
chatter_EXTERNAL_OBJECTS =

chatter: CMakeFiles/chatter.dir/main.cpp.o
chatter: CMakeFiles/chatter.dir/build.make
chatter: CMakeFiles/chatter.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=/mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable chatter"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/chatter.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/chatter.dir/build: chatter

.PHONY : CMakeFiles/chatter.dir/build

CMakeFiles/chatter.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/chatter.dir/cmake_clean.cmake
.PHONY : CMakeFiles/chatter.dir/clean

CMakeFiles/chatter.dir/depend:
	cd /mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp/cmake-build-debug && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp /mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp /mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp/cmake-build-debug /mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp/cmake-build-debug /mnt/ssd/Develop/NHLStendenProjectsPrivate/Chatterbox/chatter-cpp/cmake-build-debug/CMakeFiles/chatter.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/chatter.dir/depend
