import React, { useState, useEffect } from "react"
import { SafeAreaView } from "react-native-safe-area-context"
import { FlatList, Text, TouchableOpacity, View } from "react-native"
import Event_Item from "../../components/Event_Item"
import { AntDesign } from "@expo/vector-icons"
const data = [
  {
    id: "1",
    namePage: "CLB Sách và hành động",
    des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
    time: "20/05/2024 15:30",
    read: true,
  },
  {
    id: "2",
    namePage: "CLB Làn sóng",
    des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
    time: "20/05/2024 15:30",
    read: false,
  },
  {
    id: "3",
    namePage: "CLB Bóng đá",
    des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
    time: "20/05/2024 15:30",
    read: true,
  },
  {
    id: 4,
    namePage: "CLB nhận thức",
    des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
    time: "20/05/2024 15:30",
    read: true,
  },
  {
    id: 5,
    namePage: "CLB Sách và hành động",
    des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
    time: "20/05/2024 15:30",
    read: true,
  },
  {
    id: 6,
    namePage: "CLB Sách và hành động",
    des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
    time: "20/05/2024 15:30",
    read: false,
  },
  {
    id: 7,
    namePage: "CLB Sách và hành động",
    des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
    time: "20/05/2024 15:30",
    read: true,
  },
  {
    id: 8,
    namePage: "CLB Sách và hành động",
    des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
    time: "20/05/2024 15:30",
    read: false,
  },
]
import { useRouter } from "expo-router"
function management_event() {
  const router = useRouter()
  return (
    <SafeAreaView className='flex-1 bg-slate-50'>
      <View className='my-2 mt-3 flex flex-col items-center justify-center bg-white'>
        <Text className='text-xl font-semibold text-sky-600'>
          Quản lý sự kiện
        </Text>
      </View>
      <FlatList
        data={data}
        className='mx-2 bg-transparent'
        showsVerticalScrollIndicator={false}
        renderItem={({ item }) => <Event_Item item={item} />}
      />
      <View className='absolute bottom-3 right-3 my-2 items-center justify-center'>
        <TouchableOpacity
          className='rounded-full bg-blue-500  p-3'
          onPress={() => router.navigate("(page)/Add_Post/add-post")}
        >
          <AntDesign name='plus' size={24} color='white' />
        </TouchableOpacity>
      </View>
    </SafeAreaView>
  )
}

export default management_event
