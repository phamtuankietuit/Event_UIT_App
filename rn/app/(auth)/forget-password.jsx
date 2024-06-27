import React, { useState } from "react"
import {
  View,
  Image,
  TextInput,
  TouchableOpacity,
  Text,
  ToastAndroid,
  ActivityIndicator,
} from "react-native"
import { SafeAreaView } from "react-native-safe-area-context"
import { AntDesign } from "@expo/vector-icons"
import { Link } from "expo-router"
import { useRouter } from "expo-router"

import * as authServices from "../apiServices/authServices"

const img1 = require("../../assets/images/verification.png")
const img2 = require("../../assets/images/otp.png")
const img3 = require("../../assets/images/createpass.jpg")

const ChangePasswordScreen = () => {
  const showToastWithGravity = (msg) => {
    ToastAndroid.showWithGravity(msg, ToastAndroid.SHORT, ToastAndroid.CENTER)
  }

  const [loading, setLoading] = useState(false)

  const router = useRouter()

  const [step, setStep] = useState(1) // State to manage current step
  const [email, setEmail] = useState("")
  const [otp, setOTP] = useState("")
  const [renewPassword, setRenewPassword] = useState("")
  const [newPassword, setNewPassword] = useState("")

  const handleNext = async () => {
    if (step === 1) {
      // Validate email here
      if (email == "" || email == undefined) {
        showToastWithGravity("Vui lòng nhập email")
      } else {
        setLoading(true)
        console.log(email)
        const validation = await authServices
          .verifyEmail({ Email: email })
          .catch((error) => {
            // xử lý lỗi
            console.log(error)
            showToastWithGravity("Vui lòng kiểm tra lại email")
            setLoading(false)
          })
        if (validation) {
          // Xử lý nếu response trả về
          console.log(validation)
          showToastWithGravity("Xác thực thành công")
          // thực hiện lưu trạng thái đăng nhập
          setLoading(false)
          setStep(2)
        }
        // Move to next step
      }
    } else if (step === 2) {
      // Validate OTP here
      if (otp == "" || otp == undefined) {
        showToastWithGravity("Vui lòng nhập OTP")
      } else {
        setLoading(true)
        console.log(otp)
        const OtpValidation = await authServices
          .verifyOTP({ email: email, otp: otp })
          .catch((error) => {
            // xử lý lỗi
            console.log(error)
            showToastWithGravity("Mã OTP không đúng")
            setLoading(false)
          })
        if (OtpValidation) {
          // Xử lý nếu response trả về
          console.log(OtpValidation)
          showToastWithGravity("Xác thực thành công")
          // thực hiện lưu trạng thái đăng nhập
          setLoading(false)
          setStep(3)
        }
      }
      // Move to next step
    } else if (step === 3) {
      // Validate passwords here
      if (
        newPassword == "" ||
        newPassword == undefined ||
        renewPassword == "" ||
        renewPassword == undefined
      ) {
        showToastWithGravity("Vui lòng nhập đủ thông tin")
      } else {
        if (newPassword !== renewPassword) {
          showToastWithGravity("Mật khẩu mới không trùng khớp")
        } else {
          setLoading(true)
          const resetPass = await authServices
            .resetPass({
              email: email,
              newPassword: newPassword,
              isVerified: true,
            })
            .catch((error) => {
              // xử lý lỗi
              console.log(error.response.data.detail)
              showToastWithGravity(
                "Mật khẩu phải có ít nhất 1 kí tự đặt biệt và 1 chữ cái in hoa"
              )
              setLoading(false)
            })
          if (resetPass) {
            // Xử lý nếu response trả về
            showToastWithGravity("Đổi mật khẩu thành công!")
            // thực hiện lưu trạng thái đăng nhập
            setLoading(false)
            router.replace("(auth)/sign-in")
          }
        }
      }
    }
  }

  const handleBack = () => {
    if (step === 2) {
      setStep(1) // Move back to step 1
    } else if (step === 3) {
      setStep(2) // Move back to step 2
    }
  }

  const renderStepContent = () => {
    switch (step) {
      case 1:
        return (
          <View className='w-full flex-1 items-center'>
            <View className='w-full flex-row items-center justify-center '>
              <Link
                href={"(auth)/sign-in"}
                className='absolute left-2  self-center'
              >
                <AntDesign name='arrowleft' size={25} color={"#0284C7"} />
              </Link>
              <Text className='text-lg font-semibold text-sky-600'>
                Xác thực Email
              </Text>
            </View>
            <Image
              source={img1}
              className='mb-2 h-[260] w-[260]'
              resizeMode='contain'
            />
            <View className='mb-3 w-full justify-center px-9'>
              <TextInput
                value={email}
                onChangeText={(e) => setEmail(e)}
                placeholder='Nhập email'
                placeholderTextColor='rgba(2, 132, 199, 0.5)'
                className=' rounded-xl border-sky-600 p-3 text-sky-600'
                style={{
                  borderWidth: 2,
                  backgroundColor: "rgba(2, 132, 199, 0.1)",
                }}
              />
              {loading && (
                <ActivityIndicator className='absolute right-2'></ActivityIndicator>
              )}
            </View>
            <View className=' flex-row gap-3 px-9'>
              <TouchableOpacity
                className={`rounded px-5 py-2 ${step === 1 ? "bg-gray-400" : "bg-sky-600"}`}
                onPress={handleBack}
                disabled={step === 1}
              >
                <Text
                  className={` font-semibold ${step === 1 ? " text-gray-600" : "text-white"}`}
                >
                  Back
                </Text>
              </TouchableOpacity>
              <TouchableOpacity
                className='rounded bg-sky-600 px-5 py-2'
                onPress={handleNext}
              >
                <Text className='font-semibold text-white'>Next</Text>
              </TouchableOpacity>
            </View>
          </View>
        )
      case 2:
        return (
          <View className='w-full flex-1 items-center'>
            <View className='w-full flex-row items-center justify-center '>
              <Link
                href={"(auth)/sign-in"}
                className='absolute left-2  self-center'
              >
                <AntDesign name='arrowleft' size={25} color={"#0284C7"} />
              </Link>
              <Text className='text-lg font-semibold text-sky-600'>
                Xác nhận OTP
              </Text>
            </View>
            <Image
              source={img2}
              className='mb-2 h-[260] w-[260]'
              resizeMode='contain'
            />
            <View className='mb-3 w-full justify-center px-9'>
              <TextInput
                value={otp}
                onChangeText={(e) => setOTP(e)}
                placeholder='Nhập OTP'
                placeholderTextColor='rgba(2, 132, 199, 0.5)'
                className='  rounded-xl border-sky-600 p-3 text-sky-600'
                style={{
                  borderWidth: 2,
                  backgroundColor: "rgba(2, 132, 199, 0.1)",
                }}
              />
              {loading && (
                <ActivityIndicator className='absolute right-2'></ActivityIndicator>
              )}
            </View>
            <View className='flex-row gap-3 px-9'>
              <TouchableOpacity
                className={`rounded px-5 py-2 ${step === 1 ? "bg-gray-400" : "bg-sky-600"}`}
                onPress={handleBack}
                disabled={step === 1}
              >
                <Text
                  className={` font-semibold ${step === 1 ? " text-gray-600" : "text-white"}`}
                >
                  Back
                </Text>
              </TouchableOpacity>
              <TouchableOpacity
                className='rounded bg-sky-600 px-5 py-2'
                onPress={handleNext}
              >
                <Text className='font-semibold text-white'>Next</Text>
              </TouchableOpacity>
            </View>
          </View>
        )
      case 3:
        return (
          <View className='w-full flex-1 items-center'>
            <View className='w-full flex-row items-center justify-center '>
              <Link
                href={"(auth)/sign-in"}
                className='absolute left-2  self-center'
              >
                <AntDesign name='arrowleft' size={25} color={"#0284C7"} />
              </Link>
              <Text className='text-lg font-semibold text-sky-600'>
                Tạo mật khẩu mới
              </Text>
            </View>
            <Image
              source={img1}
              className='mb-2 h-[260] w-[260]'
              resizeMode='contain'
            />
            <View className='w-full px-9'>
              <TextInput
                value={newPassword}
                onChangeText={(e) => setNewPassword(e)}
                placeholder='Mật khẩu mới'
                secureTextEntry
                placeholderTextColor='rgba(2, 132, 199, 0.5)'
                className=' mb-1 rounded-xl border-sky-600 px-3 py-2 text-sky-600'
                style={{
                  borderWidth: 2,
                  backgroundColor: "rgba(2, 132, 199, 0.1)",
                }}
              />
              <View className='mb-3 justify-center'>
                <TextInput
                  value={renewPassword}
                  onChangeText={(e) => setRenewPassword(e)}
                  placeholder='Nhập lại mật khẩu mới'
                  secureTextEntry
                  placeholderTextColor='rgba(2, 132, 199, 0.5)'
                  className='  rounded-xl border-sky-600 px-3 py-2 text-sky-600'
                  style={{
                    borderWidth: 2,
                    backgroundColor: "rgba(2, 132, 199, 0.1)",
                  }}
                />
                {loading && (
                  <ActivityIndicator className='absolute right-2'></ActivityIndicator>
                )}
              </View>
            </View>
            <View className='flex-row gap-3 px-9'>
              <TouchableOpacity
                className={`rounded px-5 py-2 ${step === 1 ? "bg-gray-400" : "bg-sky-600"}`}
                onPress={handleBack}
                disabled={step === 1}
              >
                <Text
                  className={` font-semibold ${step === 1 ? " text-gray-600" : "text-white"}`}
                >
                  Back
                </Text>
              </TouchableOpacity>
              <TouchableOpacity
                className='rounded bg-sky-600 px-5 py-2'
                onPress={handleNext}
              >
                <Text className='font-semibold text-white'>Next</Text>
              </TouchableOpacity>
            </View>
          </View>
        )
      default:
        return null
    }
  }

  return (
    <SafeAreaView className='flex-1 bg-white'>
      <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
        {renderStepContent()}
        {/* <View className='flex-row gap-5'>
          <TouchableOpacity
            className={`rounded px-5 py-2 ${step === 1 ? "bg-gray-400" : "bg-sky-600"}`}
            onPress={handleBack}
            disabled={step === 1}
          >
            <Text
              className={` font-semibold ${step === 1 ? " text-gray-600" : "text-white"}`}
            >
              Back
            </Text>
          </TouchableOpacity>
          <TouchableOpacity
            className='rounded bg-sky-600 px-5 py-2'
            onPress={handleNext}
          >
            <Text className='font-semibold text-white'>Next</Text>
          </TouchableOpacity>
        </View> */}
      </View>
    </SafeAreaView>
  )
}

export default ChangePasswordScreen
