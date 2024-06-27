import {
  View,
  Text,
  SafeAreaView,
  Image,
  TextInput,
  TouchableOpacity,
  ToastAndroid,
  ActivityIndicator,
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
  ToastAndroid.showWithGravity(msg, ToastAndroid.SHORT, ToastAndroid.CENTER)
}

const SignIn = () => {
  const [loading, setLoading] = useState(false)

  const [email, setEmail] = useState("")
  const [password, setPassword] = useState("")

  const [showPassword, setShowPassword] = useState(false)

  const handleLogin = async () => {
    if (
      email == "" ||
      email == undefined ||
      password == "" ||
      password == undefined
    ) {
      showToastWithGravity("Vui lòng nhập đủ thông tin")
    } else {
      setLoading(true)
      const response = await authServices
        .loginStudent({
          email: email,
          password: password,
        })
        .catch((error) => {
          // xử lý lỗi
          if (error.response) {
            if (error.response.status === 401) {
              showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
              setLoading(false)
            } else if (error.response.status === 403) {
              showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
              setLoading(false)
            }
          } else {
            showToastWithGravity("Có lỗi xảy ra")
            setLoading(false)
          }
        })
      if (response) {
        // Xử lý nếu response trả về
        console.log(response)
        showToastWithGravity("Đăng nhập thành công")
        // thực hiện lưu trạng thái đăng nhập
        setLoading(false)
        // asyncStorage.setIsLogin("true")
        // asyncStorage.setRole("student")
        // asyncStorage.setAccessToken(response.accessToken)
      }
    }
  }

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
            value={email}
            onChangeText={(e) => setEmail(e)}
          ></TextInput>
        </View>
        <View className=' mb-3 w-full flex-row rounded-2xl bg-black/10 p-3'>
          <TextInput
            placeholder='Password'
            placeholderTextColor={"gray"}
            secureTextEntry={!showPassword}
            value={password}
            onChangeText={(e) => setPassword(e)}
          ></TextInput>
        </View>
        <View className='mb-2 mt-3 w-full'>
          <TouchableOpacity
            className='flex-row items-center justify-center rounded-xl bg-blue-600 p-3'
            onPress={handleLogin}
          >
            {loading && (
              <ActivityIndicator
                size={"small"}
                color={"#fff"}
                className='mr-2'
              ></ActivityIndicator>
            )}
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
