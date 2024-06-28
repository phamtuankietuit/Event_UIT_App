import React, { useState, useEffect } from "react"
import { SafeAreaView } from "react-native-safe-area-context"
import { FlatList, Text, TouchableOpacity, View } from "react-native"
import Event_Item from "../../components/Event_Item"
import { AntDesign } from "@expo/vector-icons"
import * as PageServices from "../../apiServices/pageServices"
import { useLocalSearchParams } from "expo-router"
import { useRouter } from "expo-router"
function management_event() {
  const router = useRouter()
  const params = useLocalSearchParams()
  const [list, setList] = useState("")

  useEffect(() => {
    const fetchApi = async () => {
      const response = await PageServices.getPage(params.id).catch((error) => {
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
        setList(response?.hostedEvent)
      }
    }
    fetchApi()
  }, [])
  return (
    <View className='flex-1 bg-slate-50'>
      <View className='my-2 mt-3 flex flex-col items-center justify-center bg-white'>
        <Text className='text-xl font-semibold text-sky-600'>
          Quản lý sự kiện
        </Text>
      </View>
      <FlatList
        data={list}
        className='mx-2 bg-transparent'
        showsVerticalScrollIndicator={false}
        renderItem={({ item }) => <Event_Item item={item} deleteButton />}
      />
      <View className='absolute bottom-3 right-3 my-2 items-center justify-center'>
        <TouchableOpacity
          className='rounded-full bg-blue-500  p-3'
          onPress={() => router.navigate("(page)/add-post")}
        >
          <AntDesign name='plus' size={24} color='white' />
        </TouchableOpacity>
      </View>
    </View>
  )
}

export default management_event
