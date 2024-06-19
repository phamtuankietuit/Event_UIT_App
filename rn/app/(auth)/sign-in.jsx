import {
  View,
  Text,
  SafeAreaView,
  Image,
  TextInput,
  TouchableOpacity,
} from "react-native"
import React from "react"
import { StatusBar } from "expo-status-bar"

const background = require("../../assets/images/loginbackground.png")
const light = require("../../assets/images/light.png")
const logo = require("../../assets/images/Logo.png")

const SignIn = () => {
  return (
    <SafeAreaView className='flex-1 bg-white'>
      <Image className='absolute h-full w-full' source={background}></Image>
      <StatusBar style='light'></StatusBar>
      <View className='absolute w-full flex-row justify-around'>
        <Image className='h-[200] w-[80]' source={light}></Image>
        <Image className='h-[160] w-[65]' source={light}></Image>
      </View>
      {/* Login Form */}
      <View className='absolute bottom-0 h-1/2 w-full pl-5 pr-5'>
        <View className=' flex-row items-center justify-center'>
          <View className=' -ml-8 h-[65] w-[65]'>
            <Image source={logo} className='absolute h-full w-full'></Image>
          </View>
          <Text className='text-3xl font-bold text-blue-600'>LOGIN</Text>
        </View>
        <View className='mb-3 w-full rounded-2xl bg-black/10 p-3'>
          <TextInput
            placeholder='Email'
            placeholderTextColor={"gray"}
          ></TextInput>
        </View>
        <View className='mb-3 w-full rounded-2xl bg-black/10 p-3'>
          <TextInput
            placeholder='Password'
            placeholderTextColor={"gray"}
            secureTextEntry
          ></TextInput>
        </View>
        <View className='mb-2 mt-3 w-full'>
          <TouchableOpacity className='rounded-xl bg-blue-600 p-3'>
            <Text
              className='text-center font-bold text-white'
              style={{ fontSize: 17 }}
            >
              Login
            </Text>
          </TouchableOpacity>
        </View>
        <View className='flex-row justify-center'>
          <Text>Don't have an account?</Text>
          <TouchableOpacity>
            <Text className='ml-1 font-bold text-blue-600'>SignUp</Text>
          </TouchableOpacity>
        </View>
      </View>
    </SafeAreaView>
  )
}

export default SignIn
