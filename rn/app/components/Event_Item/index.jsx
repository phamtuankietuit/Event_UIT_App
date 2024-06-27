import React from "react"
import { Text, TouchableOpacity, View, Image } from "react-native"
import { format } from "date-fns"
import logo from "../../../assets/images/anhtruong.jpg"
import { FontAwesomeIcon } from "@fortawesome/react-native-fontawesome"
import { faTrash } from "@fortawesome/free-solid-svg-icons"
function Event_Item({ item, deleteItem }) {
  return (
    <TouchableOpacity
      className='mx-2 my-[5px] h-[90px] flex-row  items-center rounded-lg bg-white p-1'
      style={{
        shadowColor: "#000",
        shadowOffset: {
          width: 0,
          height: 2,
        },
        shadowOpacity: 0.23,
        shadowRadius: 2.62,

        elevation: 4,
      }}
    >
      <View className='text-wrap flex h-[100%] w-[25%] items-center justify-center'>
        <Image
          source={logo}
          className='me-4 h-[85%] w-[85%] rounded-[3px] bg-white'
        />
      </View>
      <View className='mr-3 flex-1'>
        <Text numberOfLines={2} className='mb-3 font-semibold'>
          Seminar nghiên cứu khoa học về AI cùng UIT, hãy tham gia để có các
          phần quà thú vị
        </Text>
        <Text className='text-xs'>
          Thời gian {format(new Date(), "dd/MM/yyyy - HH:mm")}
        </Text>
      </View>
      <TouchableOpacity className='mr-2 flex items-center justify-center'>
        <View className='rounded-full bg-red-400 p-3'>
          <FontAwesomeIcon icon={faTrash} color='white' />
        </View>
      </TouchableOpacity>
    </TouchableOpacity>
  )
}

export default Event_Item
