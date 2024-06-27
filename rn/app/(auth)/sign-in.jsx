import {
  View,
  Text,
  SafeAreaView,
  Image,
  TextInput,
  TouchableOpacity,
  ToastAndroid,
} from "react-native"
import { Link } from "expo-router"
import { useEffect, useState } from "react"
import { StatusBar } from "expo-status-bar"

const background = require("../../assets/images/loginbackground.png")
const light = require("../../assets/images/light.png")
const logo = require("../../assets/images/Logo.png")

import * as authServices from "../apiServices/authServices"
import * as asyncStorage from "../store/asyncStorage"

const showToastWithGravity = (msg) => {
  ToastAndroid.showWithGravity(
    msg || "hello",
    ToastAndroid.SHORT,
    ToastAndroid.CENTER
  )
}

const SignIn = () => {
  const handleLogin = async () => {
    const response = await authServices
      .loginStudent({
        email: "275316@gm.uit.edu.vn",
        password: "Abc123@",
      })
      .catch((error) => {
        // xử lý lỗi
        if (error.response) {
          if (error.response.status === 401) {
            showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
          } else if (error.response.status === 403) {
            showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
          }
        } else {
          showToastWithGravity("Có lỗi xảy ra")
        }
      })

    if (response) {
      // Xử lý nếu response trả về
      console.log(response)
      showToastWithGravity("Đăng nhập thành công")

      // thực hiện lưu trạng thái đăng nhập
      asyncStorage.setIsStudentLogin("true")
      asyncStorage.setStudentAccessToken(response.accessToken)
    }
  }

  useEffect(() => {
    handleLogin()
  }, [])

  return (
    <SafeAreaView className='flex-1 bg-white'>
      <Image className='absolute h-full w-full' source={background}></Image>
      <StatusBar style='light'></StatusBar>
      <View className='absolute w-full flex-row justify-around'>
        <Image className='h-[200] w-[80]' source={light}></Image>
        <Image className='h-[160] w-[65]' source={light}></Image>
      </View>
      <View className='flex h-full  w-full justify-around pb-60'>
        <View className='flex items-center'>
          <Text className='text-3xl font-bold tracking-wider text-white'>
            UIT EVENT
          </Text>
        </View>
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
          <TouchableOpacity
            className='rounded-xl bg-blue-600 p-3'
            onPress={handleLogin}
          >
            <Text
              className='text-center font-bold text-white'
              style={{ fontSize: 17 }}
            >
              Login
            </Text>
          </TouchableOpacity>
        </View>
        <View className='flex-row justify-center'>
          <Text>Forget Password? </Text>
          <Link href={"(auth)/forget-password"}>
            <Text className='ml-1 font-bold text-blue-600'>Yes</Text>
          </Link>
        </View>
      </View>
    </SafeAreaView>
  )
}

export default SignIn
