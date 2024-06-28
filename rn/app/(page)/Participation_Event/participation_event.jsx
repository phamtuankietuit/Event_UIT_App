import React, { useState, useEffect } from "react"
import { SafeAreaView } from "react-native-safe-area-context"
import {
  FlatList,
  Image,
  Modal,
  Text,
  TouchableOpacity,
  View,
} from "react-native"
import Parti_Event_Item from "../../components/Participation_Event_Item"
import * as StudentServices from "../../apiServices/studentServices"
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
function participation_event() {
  const [list, setList] = useState([])
  useEffect(() => {
    console.log('đã vào');
    const fetchApi = async () => {
      const response = await StudentServices.getRegisteredEvents().catch((error) => {
        // xử lý lỗi
        if (error.response) {
          console.log(error.response);
          if (error.response.status === 401) {
            showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
          } else if (error.response.status === 403) {
            showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
          }
        } else {
          console.log(error);
          showToastWithGravity("Có lỗi xảy ra")
        }
      })

      if (response) {
        // Xử lý nếu response trả về
        console.log(response);
        setList(response.events.items)
      }
    }
    fetchApi()
  }, [])
  return (
    <View className='mt-1 flex-1'>
      <View className='mt-3 flex flex-col items-center justify-center'>
        <Text className='text-xl font-semibold text-sky-600'>
          Sự kiện tham gia
        </Text>
      </View>
      <FlatList
        data={list}
        showsVerticalScrollIndicator={false}
        className='mx-2 bg-transparent'
        renderItem={({ item }) => <Parti_Event_Item item={item} />}
      />
    </View>
  )
}

export default participation_event
