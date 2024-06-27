import React, { useEffect, useState } from "react"
import { FlatList, Text, TouchableOpacity, View } from "react-native"
import { SafeAreaView } from "react-native-safe-area-context"
import { FontAwesomeIcon } from "@fortawesome/react-native-fontawesome"
import { faListCheck } from "@fortawesome/free-solid-svg-icons"
import Notifi_Item from "../components/Notification_Item"

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

const Noti = () => {
  const [list, setList] = useState([])
  const [day, setDay] = useState(new Date())
  useEffect(() => {
    setList(data)
  }, [])

  const setRead = async () => {
    let newList = list

    newList.map((item, index) => {
      newList[index].read = true
    })
    setList(newList)
    setDay(new Date())
  }
  useEffect(() => { }, [day])
  return (
    <View className='flex-1 mt-2'>
      <View className='mx-1 mb-3 flex flex-row items-center justify-between '>
        <Text className='px-2 text-[17px] font-bold'>Mới</Text>
        <TouchableOpacity onPress={() => setRead()}>
          <View className='flex flex-row items-center justify-between '>
            <FontAwesomeIcon icon={faListCheck} />
            <Text className='mx-2'>Đánh giấu đã đọc</Text>
          </View>
        </TouchableOpacity>
      </View>
      <FlatList
        data={list}
        showsVerticalScrollIndicator={false}
        className='mx-2 bg-transparent'
        renderItem={({ item }) => <Notifi_Item item={item} />}
      />
    </View>
  )
}

export default Noti
