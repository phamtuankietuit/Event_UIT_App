import { View, Text, TouchableOpacity } from "react-native"
import React from "react"
import { Ionicons } from "@expo/vector-icons"
import { useRouter } from "expo-router"

const MyHeader = ({ title }) => {
  const router = useRouter()

  return (
    <View
      className={`flex-row items-center bg-white p-3 shadow-sm shadow-black`}
    >
      <TouchableOpacity onPress={router.back}>
        <Ionicons name='arrow-back' size={24} color='black' />
      </TouchableOpacity>
      <View className='flex-1 items-center justify-center'>
        <Text className='mr-6 text-center text-lg font-medium'>{title}</Text>
      </View>
    </View>
  )
}

export default MyHeader
