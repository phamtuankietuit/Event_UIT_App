import React, { useState } from "react"
import { View, Image, TextInput, TouchableOpacity, Text } from "react-native"
import { SafeAreaView } from "react-native-safe-area-context"
import { AntDesign } from "@expo/vector-icons"

const img1 = require("../../assets/images/verification.png")
const img2 = require("../../assets/images/otp.png")
const img3 = require("../../assets/images/createpass.jpg")

const ChangePasswordScreen = () => {
  const [step, setStep] = useState(1) // State to manage current step
  const [email, setEmail] = useState("")
  const [otp, setOTP] = useState("")
  const [currentPassword, setCurrentPassword] = useState("")
  const [newPassword, setNewPassword] = useState("")

  const handleNext = () => {
    if (step === 1) {
      // Validate email here
      setStep(2) // Move to next step
    } else if (step === 2) {
      // Validate OTP here
      setStep(3) // Move to next step
    } else if (step === 3) {
      // Validate passwords here
      // Perform password change logic
      // Navigate to success screen or home screen
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
              <TouchableOpacity className='absolute left-2  self-center'>
                <AntDesign name='arrowleft' size={25} color={"#0284C7"} />
              </TouchableOpacity>
              <Text className='text-lg font-semibold text-sky-600'>
                Xác thực Email
              </Text>
            </View>
            <Image
              source={img1}
              className='mb-2 h-[260] w-[260]'
              resizeMode='contain'
            />
            <View className='w-full px-9'>
              <TextInput
                value={email}
                onChangeText={setEmail}
                placeholder='Nhập email'
                placeholderTextColor='rgba(2, 132, 199, 0.5)'
                className=' mb-3 rounded-xl border-sky-600 p-3 text-sky-600'
                style={{
                  borderWidth: 2,
                  backgroundColor: "rgba(2, 132, 199, 0.1)",
                }}
              />
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
      case 2:
        return (
          <View className='w-full flex-1 items-center'>
            <View className='w-full flex-row items-center justify-center '>
              <TouchableOpacity className='absolute left-2  self-center'>
                <AntDesign name='arrowleft' size={25} color={"#0284C7"} />
              </TouchableOpacity>
              <Text className='text-lg font-semibold text-sky-600'>
                Xác nhận OTP
              </Text>
            </View>
            <Image
              source={img2}
              className='mb-2 h-[260] w-[260]'
              resizeMode='contain'
            />
            <View className='w-full px-9'>
              <TextInput
                value={email}
                onChangeText={setEmail}
                placeholder='Nhập OTP'
                placeholderTextColor='rgba(2, 132, 199, 0.5)'
                className=' mb-3 rounded-xl border-sky-600 p-3 text-sky-600'
                style={{
                  borderWidth: 2,
                  backgroundColor: "rgba(2, 132, 199, 0.1)",
                }}
              />
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
              <TouchableOpacity className='absolute left-2  self-center'>
                <AntDesign name='arrowleft' size={25} color={"#0284C7"} />
              </TouchableOpacity>
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
                value={currentPassword}
                onChangeText={setCurrentPassword}
                placeholder='Mật khẩu hiện tại'
                secureTextEntry
                placeholderTextColor='rgba(2, 132, 199, 0.5)'
                className=' mb-1 rounded-xl border-sky-600 px-3 py-2 text-sky-600'
                style={{
                  borderWidth: 2,
                  backgroundColor: "rgba(2, 132, 199, 0.1)",
                }}
              />
              <TextInput
                value={newPassword}
                onChangeText={setNewPassword}
                placeholder='Mật khẩu mới'
                secureTextEntry
                placeholderTextColor='rgba(2, 132, 199, 0.5)'
                className=' mb-3 rounded-xl border-sky-600 px-3 py-2 text-sky-600'
                style={{
                  borderWidth: 2,
                  backgroundColor: "rgba(2, 132, 199, 0.1)",
                }}
              />
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
